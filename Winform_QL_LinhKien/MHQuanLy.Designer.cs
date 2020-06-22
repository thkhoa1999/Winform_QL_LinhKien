namespace Winform_QL_LinhKien
{
    partial class MHQuanLy
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
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.lbSoDienThoai = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.txtTenNhanVien = new System.Windows.Forms.TextBox();
            this.lbTenNhanVien = new System.Windows.Forms.Label();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.lbMaNhanVien = new System.Windows.Forms.Label();
            this.gvDSDHCD = new System.Windows.Forms.DataGridView();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaDonHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuongLinhKien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbDSDHCD = new System.Windows.Forms.Label();
            this.btnDuyetDonHang = new System.Windows.Forms.Button();
            this.btnQuanLyDanhMuc = new System.Windows.Forms.Button();
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
            this.toolStrip.Size = new System.Drawing.Size(807, 25);
            this.toolStrip.TabIndex = 7;
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
            this.toolStripButtonQuayLai.Click += new System.EventHandler(this.toolStripButtonQuayLai_Click);
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(569, 83);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(218, 20);
            this.txtSoDienThoai.TabIndex = 22;
            // 
            // lbSoDienThoai
            // 
            this.lbSoDienThoai.AutoSize = true;
            this.lbSoDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoDienThoai.Location = new System.Drawing.Point(443, 81);
            this.lbSoDienThoai.Name = "lbSoDienThoai";
            this.lbSoDienThoai.Size = new System.Drawing.Size(120, 22);
            this.lbSoDienThoai.TabIndex = 21;
            this.lbSoDienThoai.Text = "Số điện thoại:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(569, 43);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(218, 20);
            this.txtDiaChi.TabIndex = 20;
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiaChi.Location = new System.Drawing.Point(493, 41);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(70, 22);
            this.lbDiaChi.TabIndex = 19;
            this.lbDiaChi.Text = "Địa chỉ:";
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.Location = new System.Drawing.Point(174, 83);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.Size = new System.Drawing.Size(218, 20);
            this.txtTenNhanVien.TabIndex = 18;
            // 
            // lbTenNhanVien
            // 
            this.lbTenNhanVien.AutoSize = true;
            this.lbTenNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenNhanVien.Location = new System.Drawing.Point(20, 81);
            this.lbTenNhanVien.Name = "lbTenNhanVien";
            this.lbTenNhanVien.Size = new System.Drawing.Size(133, 22);
            this.lbTenNhanVien.TabIndex = 17;
            this.lbTenNhanVien.Text = "Tên Nhân viên:";
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Location = new System.Drawing.Point(174, 43);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(218, 20);
            this.txtMaNhanVien.TabIndex = 16;
            // 
            // lbMaNhanVien
            // 
            this.lbMaNhanVien.AutoSize = true;
            this.lbMaNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaNhanVien.Location = new System.Drawing.Point(28, 41);
            this.lbMaNhanVien.Name = "lbMaNhanVien";
            this.lbMaNhanVien.Size = new System.Drawing.Size(125, 22);
            this.lbMaNhanVien.TabIndex = 15;
            this.lbMaNhanVien.Text = "Mã Nhân viên:";
            // 
            // gvDSDHCD
            // 
            this.gvDSDHCD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDSDHCD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.colMaDonHang,
            this.colMaKhachHang,
            this.colTenKhachHang,
            this.colSoLuongLinhKien,
            this.colTongTien});
            this.gvDSDHCD.Location = new System.Drawing.Point(24, 174);
            this.gvDSDHCD.Name = "gvDSDHCD";
            this.gvDSDHCD.Size = new System.Drawing.Size(615, 222);
            this.gvDSDHCD.TabIndex = 23;
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
            // colSoLuongLinhKien
            // 
            this.colSoLuongLinhKien.HeaderText = "Số lượng LK";
            this.colSoLuongLinhKien.Name = "colSoLuongLinhKien";
            // 
            // colTongTien
            // 
            this.colTongTien.HeaderText = "Tổng tiền";
            this.colTongTien.Name = "colTongTien";
            // 
            // lbDSDHCD
            // 
            this.lbDSDHCD.AutoSize = true;
            this.lbDSDHCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDSDHCD.Location = new System.Drawing.Point(21, 134);
            this.lbDSDHCD.Name = "lbDSDHCD";
            this.lbDSDHCD.Size = new System.Drawing.Size(259, 22);
            this.lbDSDHCD.TabIndex = 24;
            this.lbDSDHCD.Text = "Danh sách đơn hàng cần duyệt";
            // 
            // btnDuyetDonHang
            // 
            this.btnDuyetDonHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDuyetDonHang.Location = new System.Drawing.Point(665, 238);
            this.btnDuyetDonHang.Name = "btnDuyetDonHang";
            this.btnDuyetDonHang.Size = new System.Drawing.Size(122, 58);
            this.btnDuyetDonHang.TabIndex = 25;
            this.btnDuyetDonHang.Text = "Duyệt đơn hàng";
            this.btnDuyetDonHang.UseVisualStyleBackColor = true;
            this.btnDuyetDonHang.Click += new System.EventHandler(this.btnDuyetDonHang_Click);
            // 
            // btnQuanLyDanhMuc
            // 
            this.btnQuanLyDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyDanhMuc.Location = new System.Drawing.Point(665, 174);
            this.btnQuanLyDanhMuc.Name = "btnQuanLyDanhMuc";
            this.btnQuanLyDanhMuc.Size = new System.Drawing.Size(122, 58);
            this.btnQuanLyDanhMuc.TabIndex = 26;
            this.btnQuanLyDanhMuc.Text = "Quản lý Danh Mục";
            this.btnQuanLyDanhMuc.UseVisualStyleBackColor = true;
            this.btnQuanLyDanhMuc.Click += new System.EventHandler(this.btnQuanLyDanhMuc_Click);
            // 
            // MHQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 408);
            this.Controls.Add(this.btnQuanLyDanhMuc);
            this.Controls.Add(this.btnDuyetDonHang);
            this.Controls.Add(this.lbDSDHCD);
            this.Controls.Add(this.gvDSDHCD);
            this.Controls.Add(this.txtSoDienThoai);
            this.Controls.Add(this.lbSoDienThoai);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.lbDiaChi);
            this.Controls.Add(this.txtTenNhanVien);
            this.Controls.Add(this.lbTenNhanVien);
            this.Controls.Add(this.txtMaNhanVien);
            this.Controls.Add(this.lbMaNhanVien);
            this.Controls.Add(this.toolStrip);
            this.Name = "MHQuanLy";
            this.Text = "QUẢN LÝ";
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDSDHCD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButtonQuayLai;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Label lbSoDienThoai;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.Label lbTenNhanVien;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.Label lbMaNhanVien;
        private System.Windows.Forms.DataGridView gvDSDHCD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT; 
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDonHang; 
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaKhachHang; 
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenKhachHang; 
        private System.Windows.Forms.DataGridViewTextBoxColumn colTongTien; 
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuongLinhKien;
        private System.Windows.Forms.Label lbDSDHCD;
        private System.Windows.Forms.Button btnDuyetDonHang;
        private System.Windows.Forms.Button btnQuanLyDanhMuc;
    }
}