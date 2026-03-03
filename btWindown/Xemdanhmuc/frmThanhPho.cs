using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text; 
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace btWindown.Xemdanhmuc
{
    public partial class frmThanhPho : Form
    {
        string ketnoi = "Data Source=MEDIA\\SQLEXPRESS;Initial Catalog=quanlybanhang;Integrated Security=True" ;
            SqlConnection conn = null;
            SqlDataAdapter daTable = null;
            DataTable dtTable = null;

        public frmThanhPho()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

        }

        private void frmThanhPho_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(ketnoi);
                int intDM = Convert.ToInt32(this.Text);
                switch (intDM)
                {
                    case 1:
                        this.Text = "Danh mục Thành Phố";
                        lblDanhmuc.Text = "Danh mục Thành phố";
                        daTable = new SqlDataAdapter("select Thanhpho, Tenthanhpho From thanhpho", conn);
                    break;

                    case 2:
                        this.Text = "Danh mục Khách hàng";
                        lblDanhmuc.Text = "Danh mục Khách hàng";
                        daTable = new SqlDataAdapter("select * from khachhang", conn);
                    break;

                    case 3:
                        this.Text = "Danh mục Nhân viên";
                        lblDanhmuc.Text = "Danh mục Nhân viên";
                        daTable = new SqlDataAdapter("select * from nhanvien", conn);
                    break;

                    case 4:
                        this.Text = "Danh mục Sản phẩm ";
                        lblDanhmuc.Text = "danh mục Sản phẩm";
                        daTable = new SqlDataAdapter("select * from sanpham", conn);
                    break;

                    case 5:
                        this.Text = "Danh mục Hóa đơn";
                        lblDanhmuc.Text = "Danh mục Hóa đơn";
                        daTable = new SqlDataAdapter("select * from hoadon", conn);
                     break;

                    case 6:
                        this.Text = "Danh mục chi tiết hóa đơn";
                        lblDanhmuc.Text = "Danh mục chi tiết hóa đơn";
                        daTable = new SqlDataAdapter("select * from chitiethoadon", conn);
                    break;
                    default:
                        break;
                        
                }
                dtTable = new DataTable();
                dtTable.Clear();
                daTable.Fill(dtTable);
                dataGridView1.DataSource = dtTable;
                dataGridView1.AutoResizeColumns();
                
            }

            catch (SqlException) {
                MessageBox.Show("Không lấy được nội dung trong bảng. Lỗi rồiiiii!");
            }
        }
        

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Chắc không?","Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK) this.Close();
            daTable.Dispose();
            daTable = null;
            conn = null;
        }
    }
}
