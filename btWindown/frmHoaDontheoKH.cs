using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace btWindown
{
    public partial class frmHoaDontheoKH : Form
    {
        string connStr = @"Data Source=DESKTOP-3INS5UR\MSSQLSERVER01;Initial Catalog=QuanLyBanHang;Integrated Security=True";

        public frmHoaDontheoKH()
        {
            InitializeComponent();
        }

        private void frmHoaDontheoKH_Load(object sender, EventArgs e)
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

                    cboKhachHang.DataSource = dt;
                    cboKhachHang.DisplayMember = "TenSP";
                    cboKhachHang.ValueMember = "MaSP";
                    cboKhachHang.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi load sản phẩm: " + ex.Message);
                }
            }
        }
        private void cboKhachHang_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cboKhachHang.SelectedValue != null && cboKhachHang.SelectedIndex != -1)
            {
                if (cboKhachHang.SelectedValue is string maSP)
                {
                    HienThiHoaDonTheoSP(maSP);
                }
                else if (cboKhachHang.SelectedValue is DataRowView drv)
                {
                    HienThiHoaDonTheoSP(drv["MaSP"].ToString());
                }
            }
        }
        void HienThiHoaDonTheoSP(string maSP)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = @"SELECT HD.MaHD, HD.NgayLapHD, HD.NgayNhanHang, CT.SoLuong 
                               FROM HoaDon HD 
                               INNER JOIN ChiTietHoaDon CT ON HD.MaHD = CT.MaHD 
                               WHERE CT.MaSP = @ma";

                try
                {
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@ma", maSP.Trim());

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvHoaDon.DataSource = dt;

                    
                    if (dt.Rows.Count == 0)
                    {
                        
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