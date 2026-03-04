using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace btWindown
{
    public partial class frmHoaDonTheoNV : Form
    {
        // Nên để Connection String ở một biến dùng chung hoặc cấu hình hệ thống
        string connStr = @"Data Source=DESKTOP-3INS5UR\MSSQLSERVER01;Initial Catalog=QuanLyBanHang;Integrated Security=True";

        public frmHoaDonTheoNV()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void frmHoaDonTheoNV_Load(object sender, EventArgs e)
        {
            LoadComboBoxNhanVien();
        }

        void LoadComboBoxNhanVien()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    // Sửa lại SQL: Kết hợp Ho và Ten thành HoTen
                    string sql = "SELECT MaNV, (Ho + ' ' + Ten) AS HoTen FROM NhanVien";
                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Quan trọng: Gán Value và Display trước khi gán DataSource
                    cboNhanVien.DisplayMember = "HoTen";
                    cboNhanVien.ValueMember = "MaNV";
                    cboNhanVien.DataSource = dt;

                    // Để mặc định không chọn nhân viên nào lúc mới load
                    cboNhanVien.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi load Nhân viên: " + ex.Message);
                }
            }
        }

        private void cboNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kiểm tra SelectedValue hợp lệ và không phải là lúc đang khởi tạo (DataRowView)
            if (cboNhanVien.SelectedValue != null && !(cboNhanVien.SelectedValue is DataRowView))
            {
                string maNV = cboNhanVien.SelectedValue.ToString();
                HienThiHoaDonTheoNV(maNV);
            }
        }

        void HienThiHoaDonTheoNV(string maNV)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                // Truy vấn lấy Hóa đơn và Tên Công ty
                string sql = @"SELECT HD.MaHD, KH.TenCty, HD.NgayLapHD, HD.NgayNhanHang
                               FROM HoaDon HD 
                               INNER JOIN KhachHang KH ON HD.MaKH = KH.MaKH
                               WHERE HD.MaNV = @maNV";

                try
                {
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@maNV", maNV.Trim());

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvHoaDon.DataSource = dt;

                    // Định dạng tiêu đề cột (Luôn chạy để đảm bảo UI đẹp)
                    if (dgvHoaDon.Columns.Count > 0)
                    {
                        dgvHoaDon.Columns["MaHD"].HeaderText = "Mã Hóa Đơn";
                        dgvHoaDon.Columns["TenCty"].HeaderText = "Khách Hàng (Cty)";
                        dgvHoaDon.Columns["NgayLapHD"].HeaderText = "Ngày Lập";
                        dgvHoaDon.Columns["NgayNhanHang"].HeaderText = "Ngày Nhận";

                        // Tự động căn chỉnh chiều rộng cột
                        dgvHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi truy vấn hóa đơn: " + ex.Message);
                }
            }
        }
    }
}