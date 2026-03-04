using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace btWindown
{
    public partial class formChiTietHoaDonTheoNV : Form
    {
        string connStr = @"Data Source=DESKTOP-3INS5UR\MSSQLSERVER01;Initial Catalog=QuanLyBanHang;Integrated Security=True";
        public formChiTietHoaDonTheoNV()
        {
            InitializeComponent();
        }

        private void formChiTietHoaDonTheoNV_Load(object sender, EventArgs e)
        {
            LoadComboBoxNhanVien();
        }
        void LoadComboBoxNhanVien()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    string sql = "SELECT MaNV, (Ho + ' ' + Ten) AS HoTen FROM NhanVien";
                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cboNhanVien.DisplayMember = "HoTen";
                    cboNhanVien.ValueMember = "MaNV";
                    cboNhanVien.DataSource = dt;
                    cboNhanVien.SelectedIndex = -1;
                }
                catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
            }
        }
        private void cboNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboNhanVien.SelectedValue != null && !(cboNhanVien.SelectedValue is DataRowView))
            {
                LoadHoaDon(cboNhanVien.SelectedValue.ToString());
                // Xóa trắng bảng chi tiết khi đổi nhân viên
                dgvChiTiet.DataSource = null;
            }
        }
        void LoadHoaDon(string maNV)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = @"SELECT HD.MaHD, KH.TenCty, HD.NgayLapHD 
                               FROM HoaDon HD 
                               JOIN KhachHang KH ON HD.MaKH = KH.MaKH 
                               WHERE HD.MaNV = @maNV";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@maNV", maNV);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvHoaDon.DataSource = dt;

                if (dgvHoaDon.Columns.Count > 0)
                    dgvHoaDon.Columns["MaHD"].HeaderText = "Mã HĐ";
            }
        }
        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy MaHD từ dòng vừa click
                string maHD = dgvHoaDon.Rows[e.RowIndex].Cells["MaHD"].Value.ToString();
                LoadChiTietHoaDon(maHD);
            }
        }
        void LoadChiTietHoaDon(string maHD)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                // Truy vấn JOIN 3 bảng để lấy tên SP và đơn giá
                string sql = @"SELECT CT.MaSP, SP.TenSP, CT.SoLuong, SP.DonGia, 
                               (CT.SoLuong * SP.DonGia) AS ThanhTien
                               FROM ChiTietHoaDon CT
                               JOIN SanPham SP ON CT.MaSP = SP.MaSP
                               WHERE CT.MaHD = @maHD";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@maHD", maHD);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvChiTiet.DataSource = dt;

                // Định dạng tiêu đề
                if (dgvChiTiet.Columns.Count > 0)
                {
                    dgvChiTiet.Columns["MaSP"].HeaderText = "Mã SP";
                    dgvChiTiet.Columns["TenSP"].HeaderText = "Tên Sản Phẩm";
                    dgvChiTiet.Columns["SoLuong"].HeaderText = "Số Lượng";
                    dgvChiTiet.Columns["DonGia"].HeaderText = "Đơn Giá";
                    dgvChiTiet.Columns["ThanhTien"].HeaderText = "Thành Tiền";
                }
            }
        }

    }
}
