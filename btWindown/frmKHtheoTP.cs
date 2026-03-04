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
    public partial class frmKHtheoTP : Form
    {
        string connStr = @"Data Source=DESKTOP-3INS5UR\MSSQLSERVER01;Initial Catalog=QuanLyBanHang;Integrated Security=True";
        public frmKHtheoTP()
        {
            InitializeComponent();
        }
        private void frmKHtheoTP_Load(object sender, EventArgs e)
        {
            LoadComboBox();
        }
        
        void LoadComboBox()
        {
            
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM ThanhPho", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cboThanhPho.DisplayMember = "TenThanhPho";
                cboThanhPho.ValueMember = "ThanhPho"; 
                cboThanhPho.DataSource = dt;
            }
        }
        private void cboThanhPho_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboThanhPho.SelectedValue != null)
              { 
                string maTP = cboThanhPho.SelectedValue.ToString();
                if (maTP != "System.Data.DataRowView")
                {
                    HienThiKhachHang(maTP);
                }
            }
        }

        void HienThiKhachHang(string ma)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = "SELECT MaKH, TenCty, DiaChi, DienThoai FROM KhachHang WHERE ThanhPho = @ma";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ma", ma.Trim());

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvKetQua.DataSource = dt; 
            }
        }
    }
}
