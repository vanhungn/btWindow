using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace btWindown
{
    public partial class formHoaDonTheoSP : Form
    {
        string connStr = @"Data Source=DESKTOP-3INS5UR\MSSQLSERVER01;Initial Catalog=QuanLyBanHang;Integrated Security=True";

        public formHoaDonTheoSP()
        {
            InitializeComponent();
        }

        private void formHoaDonTheoSP_Load(object sender, EventArgs e)
        {
            LoadComboBoxSanPham();
        }

        void LoadComboBoxSanPham()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT MaSP, TenSP FROM SanPham", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cboSanPham.DisplayMember = "TenSP";
                    cboSanPham.ValueMember = "MaSP";
                    cboSanPham.DataSource = dt;
                    cboSanPham.SelectedIndex = -1;
                }
                catch (Exception ex) { MessageBox.Show("Lỗi load SP: " + ex.Message); }
            }
        }

        private void cboKhachHang_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cboSanPham.SelectedValue != null && cboSanPham.SelectedIndex != -1)
            {
                string maSP = "";
                if (cboSanPham.SelectedValue is DataRowView drv)
                    maSP = drv["MaSP"].ToString();
                else
                    maSP = cboSanPham.SelectedValue.ToString();

                if (maSP != "System.Data.DataRowView")
                {
                    HienThiHoaDonTheoSP(maSP);
                }
            }
        }

        void HienThiHoaDonTheoSP(string maSP)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                // ĐÃ SỬA: Lấy cột TenCty thay vì TenKH
                string sql = @"SELECT HD.MaHD, KH.TenCty, HD.NgayLapHD, CT.SoLuong 
                               FROM HoaDon HD 
                               INNER JOIN ChiTietHoaDon CT ON HD.MaHD = CT.MaHD 
                               INNER JOIN KhachHang KH ON HD.MaKH = KH.MaKH
                               WHERE CT.MaSP = @ma";

                try
                {
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@ma", maSP.Trim());

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvHoaDon.DataSource = dt;

                    // ĐỔI TÊN CỘT TRÊN LƯỚI
                    if (dt.Rows.Count > 0)
                    {
                        if (dgvHoaDon.Columns["MaHD"] != null) dgvHoaDon.Columns["MaHD"].HeaderText = "Mã Hóa Đơn";
                        if (dgvHoaDon.Columns["TenCty"] != null) dgvHoaDon.Columns["TenCty"].HeaderText = "Tên Công Ty";
                        if (dgvHoaDon.Columns["NgayLapHD"] != null) dgvHoaDon.Columns["NgayLapHD"].HeaderText = "Ngày Lập";
                        if (dgvHoaDon.Columns["SoLuong"] != null) dgvHoaDon.Columns["SoLuong"].HeaderText = "Số Lượng";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi truy vấn: " + ex.Message);
                }
            }
        }
    }
}