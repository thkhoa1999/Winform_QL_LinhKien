namespace Winform_QL_LinhKien
{
    partial class MHDuyet
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
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonQuayLai = new System.Windows.Forms.ToolStripButton();
            this.txtTenNhanVien = new System.Windows.Forms.TextBox();
            this.lbTenNhanVien = new System.Windows.Forms.Label();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.lbMaNhanVien = new System.Windows.Forms.Label();
            this.lbDSDHCD = new System.Windows.Forms.Label();
            this.gvDSDHCD = new System.Windows.Forms.DataGridView();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaDonHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuongLinhKien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXemChiTiet = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDSDHCD)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonQuayLai});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip.Size = new System.Drawing.Size(630, 25);
            this.toolStrip.TabIndex = 8;
            this.toolStrip.Text = "toolStrip";
            // 
            // toolStripButtonQuayLai
            // 
            this.toolStripButtonQuayLai.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonQuayLai.Image = global::Winform_QL_LinhKien.Properties.Resources._return;
            this.toolStripButtonQuayLai.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonQuayLai.Name = "toolStripButtonQuayLai";
            this.toolStripButtonQuayLai.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonQuayLai.Text = "toolStripButtonQuayLai";
            this.toolStripButtonQuayLai.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.Location = new System.Drawing.Point(167, 84);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.Size = new System.Drawing.Size(218, 20);
            this.txtTenNhanVien.TabIndex = 22;
            // 
            // lbTenNhanVien
            // 
            this.lbTenNhanVien.AutoSize = true;
            this.lbTenNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenNhanVien.Location = new System.Drawing.Point(13, 82);
            this.lbTenNhanVien.Name = "lbTenNhanVien";
            this.lbTenNhanVien.Size = new System.Drawing.Size(133, 22);
            this.lbTenNhanVien.TabIndex = 21;
            this.lbTenNhanVien.Text = "Tên Nhân viên:";
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Location = new System.Drawing.Point(167, 44);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(218, 20);
            this.txtMaNhanVien.TabIndex = 20;
            // 
            // lbMaNhanVien
            // 
            this.lbMaNhanVien.AutoSize = true;
            this.lbMaNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaNhanVien.Location = new System.Drawing.Point(21, 42);
            this.lbMaNhanVien.Name = "lbMaNhanVien";
            this.lbMaNhanVien.Size = new System.Drawing.Size(125, 22);
            this.lbMaNhanVien.TabIndex = 19;
            this.lbMaNhanVien.Text = "Mã Nhân viên:";
            // 
            // lbDSDHCD
            // 
            this.lbDSDHCD.AutoSize = true;
            this.lbDSDHCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDSDHCD.Location = new System.Drawing.Point(14, 134);
            this.lbDSDHCD.Name = "lbDSDHCD";
            this.lbDSDHCD.Size = new System.Drawing.Size(259, 22);
            this.lbDSDHCD.TabIndex = 26;
            this.lbDSDHCD.Text = "Danh sách đơn hàng cần duyệt";
            // 
            // gvDSDHCD
            // 
            this.gvDSDHCD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDSDHCD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.colMaDonHang,
            this.colMaKhachHang,
            this.colTenKhachHang,
            this.colTongTien,
            this.colSoLuongLinhKien});
            this.gvDSDHCD.Location = new System.Drawing.Point(17, 174);
            this.gvDSDHCD.Name = "gvDSDHCD";
            this.gvDSDHCD.Size = new System.Drawing.Size(594, 222);
            this.gvDSDHCD.TabIndex = 25;
            // 
            // colSTT
            // 
            this.colSTT.HeaderText = "STT";
            this.colSTT.Name = "colSTT";
            this.colSTT.Width = 50;
            // 
            // colMaDonHang
            // 
            this.colMaDonHang.HeaderText = "Mã đơn hàng";
            this.colMaDonHang.Name = "colMaDonHang";
            // 
            // colMaKhachHang
            // 
            this.colMaKhachHang.HeaderText = "Mã KH";
            this.colMaKhachHang.Name = "colMaKhachHang";
            // 
            // colTenKhachHang
            // 
            this.colTenKhachHang.HeaderText = "Tên KH";
            this.colTenKhachHang.Name = "colTenKhachHang";
            // 
            // colTongTien
            // 
            this.colTongTien.HeaderText = "Tổng tiền";
            this.colTongTien.Name = "colTongTien";
            // 
            // colSoLuongLinhKien
            // 
            this.colSoLuongLinhKien.HeaderText = "Số lượng LK";
            this.colSoLuongLinhKien.Name = "colSoLuongLinhKien";
            // 
            // btnXemChiTiet
            // 
            this.btnXemChiTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemChiTiet.Location = new System.Drawing.Point(455, 42);
            this.btnXemChiTiet.Name = "btnXemChiTiet";
            this.btnXemChiTiet.Size = new System.Drawing.Size(122, 30);
            this.btnXemChiTiet.TabIndex = 27;
            this.btnXemChiTiet.Text = "Xem chi tiết";
            this.btnXemChiTiet.UseVisualStyleBackColor = true;
            this.btnXemChiTiet.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(455, 84);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(122, 30);
            this.btnXoa.TabIndex = 28;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // MHDuyet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 410);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnXemChiTiet);
            this.Controls.Add(this.lbDSDHCD);
            this.Controls.Add(this.gvDSDHCD);
            this.Controls.Add(this.txtTenNhanVien);
            this.Controls.Add(this.lbTenNhanVien);
            this.Controls.Add(this.txtMaNhanVien);
            this.Controls.Add(this.lbMaNhanVien);
            this.Controls.Add(this.toolStrip);
            this.Name = "MHDuyet";
            this.Text = "DUYỆT";
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDSDHCD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButtonQuayLai;
        private System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.Label lbTenNhanVien;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.Label lbMaNhanVien;
        private System.Windows.Forms.Label lbDSDHCD;
        private System.Windows.Forms.DataGridView gvDSDHCD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT; 
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDonHang; 
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaKhachHang; 
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenKhachHang; 
        private System.Windows.Forms.DataGridViewTextBoxColumn colTongTien; 
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuongLinhKien;
        private System.Windows.Forms.Button btnXemChiTiet;
        private System.Windows.Forms.Button btnXoa;
    }
}