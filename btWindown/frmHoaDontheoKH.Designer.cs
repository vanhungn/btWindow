
namespace btWindown
{
    partial class frmHoaDontheoKH
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.grbHoaDonTheoKH = new System.Windows.Forms.GroupBox();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.cboKhachHang = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grbHoaDonTheoKH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(302, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "HÓA ĐƠN THEO KHÁCH HÀNG";
            // 
            // grbHoaDonTheoKH
            // 
            this.grbHoaDonTheoKH.Controls.Add(this.dgvHoaDon);
            this.grbHoaDonTheoKH.Controls.Add(this.cboKhachHang);
            this.grbHoaDonTheoKH.Controls.Add(this.label2);
            this.grbHoaDonTheoKH.Location = new System.Drawing.Point(168, 86);
            this.grbHoaDonTheoKH.Name = "grbHoaDonTheoKH";
            this.grbHoaDonTheoKH.Size = new System.Drawing.Size(433, 267);
            this.grbHoaDonTheoKH.TabIndex = 3;
            this.grbHoaDonTheoKH.TabStop = false;
            this.grbHoaDonTheoKH.Text = "Chọn nhóm";
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Location = new System.Drawing.Point(36, 76);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.Size = new System.Drawing.Size(353, 121);
            this.dgvHoaDon.TabIndex = 2;
            // 
            // cboKhachHang
            // 
            this.cboKhachHang.FormattingEnabled = true;
            this.cboKhachHang.Location = new System.Drawing.Point(165, 27);
            this.cboKhachHang.Name = "cboKhachHang";
            this.cboKhachHang.Size = new System.Drawing.Size(150, 21);
            this.cboKhachHang.TabIndex = 1;
            this.cboKhachHang.SelectedIndexChanged += new System.EventHandler(this.cboKhachHang_SelectedIndexChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chọn thông tin khách hàng";
            // 
            // frmHoaDontheoKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbHoaDonTheoKH);
            this.Controls.Add(this.label1);
            this.Name = "frmHoaDontheoKH";
            this.Text = "frmHoaDontheoKH";
            this.Load += new System.EventHandler(this.frmHoaDontheoKH_Load);
            this.grbHoaDonTheoKH.ResumeLayout(false);
            this.grbHoaDonTheoKH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbHoaDonTheoKH;
        private System.Windows.Forms.ComboBox cboKhachHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvHoaDon;
    }
}