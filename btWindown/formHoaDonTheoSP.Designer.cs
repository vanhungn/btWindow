
namespace btWindown
{
    partial class formHoaDonTheoSP
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
            this.grbHoaDonTheoKH = new System.Windows.Forms.GroupBox();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.cboSanPham = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbHoaDonTheoKH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // grbHoaDonTheoKH
            // 
            this.grbHoaDonTheoKH.Controls.Add(this.dgvHoaDon);
            this.grbHoaDonTheoKH.Controls.Add(this.cboSanPham);
            this.grbHoaDonTheoKH.Controls.Add(this.label2);
            this.grbHoaDonTheoKH.Location = new System.Drawing.Point(184, 92);
            this.grbHoaDonTheoKH.Name = "grbHoaDonTheoKH";
            this.grbHoaDonTheoKH.Size = new System.Drawing.Size(433, 267);
            this.grbHoaDonTheoKH.TabIndex = 4;
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
            // cboSanPham
            // 
            this.cboSanPham.FormattingEnabled = true;
            this.cboSanPham.Location = new System.Drawing.Point(165, 27);
            this.cboSanPham.Name = "cboSanPham";
            this.cboSanPham.Size = new System.Drawing.Size(150, 21);
            this.cboSanPham.TabIndex = 1;
            this.cboSanPham.SelectedIndexChanged += new System.EventHandler(this.cboKhachHang_SelectedIndexChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chọn thông tin sản phẩm ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(346, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "HÓA ĐƠN THEO SẢN PHẨM ";
            // 
            // formHoaDonTheoSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grbHoaDonTheoKH);
            this.Name = "formHoaDonTheoSP";
            this.Text = "formHoaDonTheoSP";
            this.Load += new System.EventHandler(this.formHoaDonTheoSP_Load);
            this.grbHoaDonTheoKH.ResumeLayout(false);
            this.grbHoaDonTheoKH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbHoaDonTheoKH;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.ComboBox cboSanPham;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}