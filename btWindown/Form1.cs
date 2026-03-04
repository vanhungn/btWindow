using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btWindown
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chiTiếtHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void kháchHàngTheoThànhPhốToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKHtheoTP f = new frmKHtheoTP();
            f.ShowDialog();
        }

        private void hóaĐơnTheoKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
           frmHoaDontheoKH f = new frmHoaDontheoKH();
            f.ShowDialog();
        }

        private void hóaĐơnTheoSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formHoaDonTheoSP f = new formHoaDonTheoSP();
            f.ShowDialog();
        }

        private void hóaĐơnTheoNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoaDonTheoNV f = new frmHoaDonTheoNV();
            f.ShowDialog();
        }

        private void chiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formChiTietHoaDonTheoNV f = new formChiTietHoaDonTheoNV();
            f.ShowDialog();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDangNhap f = new frmDangNhap();
            f.ShowDialog();
        }
    }
}
