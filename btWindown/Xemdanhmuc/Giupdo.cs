using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btWindown.Xemdanhmuc
{
    public partial class Giupdo : Form
    {
        string loai;
        public Giupdo()
        {
            InitializeComponent();
            this.Load += Giupdo_Load;
        }

        public Giupdo(string loaiNoiDung)
        {
            InitializeComponent();
            loai = loaiNoiDung;
        }
        private void Giupdo_Load(object sender, EventArgs e)
        {
            textBox1.ScrollBars = ScrollBars.Vertical;
            
            textBox1.ReadOnly = true;
            if (loai == "huongdan")
            {
                textBox1.Text =
                        "================ HƯỚNG DẪN SỬ DỤNG PHẦN MỀM ================\r\n\r\n" +

                        "1. GIỚI THIỆU CHUNG\r\n" +
                        "Phần mềm Quản Lý Bán Hàng được xây dựng nhằm hỗ trợ cửa hàng\r\n" +
                        "trong việc quản lý sản phẩm, khách hàng và lập hóa đơn một cách\r\n" +
                        "nhanh chóng, chính xác và hiệu quả.\r\n\r\n" +

                        "2. ĐĂNG NHẬP HỆ THỐNG\r\n" +
                        "- Nhập tên đăng nhập và mật khẩu.\r\n" +
                        "- Nhấn nút Đăng nhập để vào hệ thống.\r\n" +
                        "- Nếu sai thông tin, hệ thống sẽ thông báo lỗi.\r\n\r\n" +

                        "3. QUẢN LÝ SẢN PHẨM\r\n" +
                        "- Thêm sản phẩm: Nhập đầy đủ thông tin và nhấn Lưu.\r\n" +
                        "- Sửa sản phẩm: Chọn sản phẩm cần sửa → cập nhật → Lưu.\r\n" +
                        "- Xóa sản phẩm: Chọn sản phẩm → nhấn Xóa.\r\n" +
                        "- Tìm kiếm: Nhập tên sản phẩm vào ô tìm kiếm.\r\n\r\n" +

                        "4. QUẢN LÝ KHÁCH HÀNG\r\n" +
                        "- Thêm khách hàng mới với đầy đủ thông tin.\r\n" +
                        "- Chỉnh sửa thông tin khi cần thiết.\r\n" +
                        "- Xóa khách hàng không còn giao dịch.\r\n\r\n" +

                        "5. LẬP HÓA ĐƠN BÁN HÀNG\r\n" +
                        "- Chọn khách hàng.\r\n" +
                        "- Chọn sản phẩm và nhập số lượng.\r\n" +
                        "- Hệ thống tự động tính tổng tiền.\r\n" +
                        "- Nhấn Thanh toán để hoàn tất.\r\n\r\n" +

                        "6. XEM BÁO CÁO\r\n" +
                        "- Xem danh sách hóa đơn đã bán.\r\n" +
                        "- Xem tổng doanh thu theo ngày/tháng.\r\n" +
                        "- Kiểm tra sản phẩm bán chạy.\r\n\r\n" +

                        "7. MỘT SỐ LƯU Ý\r\n" +
                        "- Không tắt phần mềm khi đang lưu dữ liệu.\r\n" +
                        "- Nên sao lưu dữ liệu định kỳ.\r\n" +
                        "- Kiểm tra kỹ thông tin trước khi thanh toán.\r\n\r\n" +

                        "=============================================================\r\n" +
                        "Liên hệ hỗ trợ kỹ thuật: 0123 456 789\r\n" +
                        "Email: hotro@quanlybanhang.com\r\n\r\n" +

                        "Xin cảm ơn bạn đã sử dụng phần mềm!";
            }
            else if (loai == "tacgia")
            {
                textBox1.Text =
                    "TÁC GIẢ PHẦN MỀM\r\n\r\n" +
                    "- Nguyễn Văn Hùng\r\n" +
                    "- Lê Toàn Diện\r\n" +
                    "- Ninh Mai Phương";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Chắc không?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK) this.Close();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
