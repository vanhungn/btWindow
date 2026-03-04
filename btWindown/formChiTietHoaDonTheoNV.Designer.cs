
namespace btWindown
{
    partial class formChiTietHoaDonTheoNV
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
            this.dgvChiTiet = new System.Windows.Forms.DataGridView();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.cboNhanVien = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grbHoaDonTheoKH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // grbHoaDonTheoKH
            // 
            this.grbHoaDonTheoKH.Controls.Add(this.dgvChiTiet);
            this.grbHoaDonTheoKH.Controls.Add(this.dgvHoaDon);
            this.grbHoaDonTheoKH.Controls.Add(this.cboNhanVien);
            this.grbHoaDonTheoKH.Controls.Add(this.label2);
            this.grbHoaDonTheoKH.Location = new System.Drawing.Point(184, 61);
            this.grbHoaDonTheoKH.Name = "grbHoaDonTheoKH";
            this.grbHoaDonTheoKH.Size = new System.Drawing.Size(434, 294);
            this.grbHoaDonTheoKH.TabIndex = 6;
            this.grbHoaDonTheoKH.TabStop = false;
            this.grbHoaDonTheoKH.Text = "Chọn nhóm";
            // 
            // dgvChiTiet
            // 
            this.dgvChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTiet.Location = new System.Drawing.Point(22, 182);
            this.dgvChiTiet.Name = "dgvChiTiet";
            this.dgvChiTiet.Size = new System.Drawing.Size(353, 106);
            this.dgvChiTiet.TabIndex = 3;
            this.dgvChiTiet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellClick);
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Location = new System.Drawing.Point(22, 67);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.Size = new System.Drawing.Size(353, 98);
            this.dgvHoaDon.TabIndex = 2;
            // 
            // cboNhanVien
            // 
            this.cboNhanVien.FormattingEnabled = true;
            this.cboNhanVien.Location = new System.Drawing.Point(165, 27);
            this.cboNhanVien.Name = "cboNhanVien";
            this.cboNhanVien.Size = new System.Drawing.Size(150, 21);
            this.cboNhanVien.TabIndex = 1;
            this.cboNhanVien.SelectedIndexChanged += new System.EventHandler(this.cboNhanVien_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chọn nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(327, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "CHI TIẾT HÓA ĐƠN THEO NHÂN VIÊN";
            // 
            // formChiTietHoaDonTheoNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grbHoaDonTheoKH);
            this.Name = "formChiTietHoaDonTheoNV";
            this.Text = "formChiTietHoaDonTheoNV";
            this.Load += new System.EventHandler(this.formChiTietHoaDonTheoNV_Load);
            this.grbHoaDonTheoKH.ResumeLayout(false);
            this.grbHoaDonTheoKH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbHoaDonTheoKH;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.ComboBox cboNhanVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvChiTiet;
        private System.Windows.Forms.Label label3;
    }
}