using btWindown.Xemdanhmuc;
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
            Xemdanhmuc(6);
        }

        public void Xemdanhmuc(int intDanhmuc)
        {
            frmThanhPho tp = new frmThanhPho();
            tp.Text = intDanhmuc.ToString();
            this.Hide();
            tp.ShowDialog();
            this.Show();
        }

        private void danhMụcThànhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Xemdanhmuc(1);
        }

        private void danhMụcKháchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Xemdanhmuc(2);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void danhMụcNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Xemdanhmuc(3);
        }

        private void danhMụcHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Xemdanhmuc(4);
        }

        private void danhMụcSảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Xemdanhmuc(5);
        }

        private void giúpĐỡToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hướngDẫnSửDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Giupdo f = new Giupdo("huongdan");
            f.ShowDialog();
            
        }

        private void tácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Giupdo f = new Giupdo("tacgia");
            f.ShowDialog();
        }
    }
}
