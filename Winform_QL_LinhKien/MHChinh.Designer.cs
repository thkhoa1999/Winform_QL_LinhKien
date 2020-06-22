namespace Winform_QL_LinhKien
{
    partial class MHChinh
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
            this.toolStripLabelDangNhap = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButtonMenu = new System.Windows.Forms.ToolStripDropDownButton();
            this.thongTinTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.dangXuatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gvDanhMucSanPham = new System.Windows.Forms.DataGridView();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaLinhKien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenLK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoaiLK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNhaSanXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.comboBoxLoaiLinhKien = new System.Windows.Forms.ComboBox();
            this.lbLoaiLinhKien = new System.Windows.Forms.Label();
            this.lbTenLinhKien = new System.Windows.Forms.Label();
            this.txtTenLinhKien = new System.Windows.Forms.TextBox();
            this.lbDanhMucSanPham = new System.Windows.Forms.Label();
            this.btnQuanLyDanhMuc = new System.Windows.Forms.Button();
            this.btnDatHang = new System.Windows.Forms.Button();
            this.txtMaNguoiDung = new System.Windows.Forms.TextBox();
            this.lbMaNguoiDung = new System.Windows.Forms.Label();
            this.txtTenNguoiDung = new System.Windows.Forms.TextBox();
            this.lbTenNguoiDung = new System.Windows.Forms.Label();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhMucSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelDangNhap,
            this.toolStripSeparator,
            this.toolStripDropDownButtonMenu});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(972, 27);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip";
            // 
            // toolStripLabelDangNhap
            // 
            this.toolStripLabelDangNhap.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripLabelDangNhap.Name = "toolStripLabelDangNhap";
            this.toolStripLabelDangNhap.Size = new System.Drawing.Size(82, 24);
            this.toolStripLabelDangNhap.Text = "Đăng nhập";
            this.toolStripLabelDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripDropDownButtonMenu
            // 
            this.toolStripDropDownButtonMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButtonMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thongTinTaiKhoan,
            this.dangXuatToolStripMenuItem});
            this.toolStripDropDownButtonMenu.Image = global::Winform_QL_LinhKien.Properties.Resources.list;
            this.toolStripDropDownButtonMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonMenu.Name = "toolStripDropDownButtonMenu";
            this.toolStripDropDownButtonMenu.Size = new System.Drawing.Size(34, 24);
            this.toolStripDropDownButtonMenu.Text = "toolStripDropDownButton";
            // 
            // thongTinTaiKhoan
            // 
            this.thongTinTaiKhoan.Name = "thongTinTaiKhoan";
            this.thongTinTaiKhoan.Size = new System.Drawing.Size(220, 26);
            this.thongTinTaiKhoan.Text = "Thông tin tài khoản";
            this.thongTinTaiKhoan.Click += new System.EventHandler(this.thongTinTaiKhoan_Click);
            // 
            // dangXuatToolStripMenuItem
            // 
            this.dangXuatToolStripMenuItem.Name = "dangXuatToolStripMenuItem";
            this.dangXuatToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.dangXuatToolStripMenuItem.Text = "Đăng xuất";
            // 
            // gvDanhMucSanPham
            // 
            this.gvDanhMucSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDanhMucSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.colMaLinhKien,
            this.colTenLK,
            this.colLoaiLK,
            this.colDonGia,
            this.colTinhTrang,
            this.colNhaSanXuat});
            this.gvDanhMucSanPham.Location = new System.Drawing.Point(15, 193);
            this.gvDanhMucSanPham.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gvDanhMucSanPham.Name = "gvDanhMucSanPham";
            this.gvDanhMucSanPham.RowHeadersWidth = 51;
            this.gvDanhMucSanPham.Size = new System.Drawing.Size(883, 351);
            this.gvDanhMucSanPham.TabIndex = 1;
            // 
            // colSTT
            // 
            this.colSTT.HeaderText = "STT";
            this.colSTT.MinimumWidth = 6;
            this.colSTT.Name = "colSTT";
            this.colSTT.Width = 50;
            // 
            // colMaLinhKien
            // 
            this.colMaLinhKien.HeaderText = "Mã linh kiện";
            this.colMaLinhKien.MinimumWidth = 6;
            this.colMaLinhKien.Name = "colMaLinhKien";
            this.colMaLinhKien.Width = 70;
            // 
            // colTenLK
            // 
            this.colTenLK.HeaderText = "Tên linh kiện";
            this.colTenLK.MinimumWidth = 6;
            this.colTenLK.Name = "colTenLK";
            this.colTenLK.Width = 125;
            // 
            // colLoaiLK
            // 
            this.colLoaiLK.HeaderText = "Loại linh kiện";
            this.colLoaiLK.MinimumWidth = 6;
            this.colLoaiLK.Name = "colLoaiLK";
            this.colLoaiLK.Width = 125;
            // 
            // colDonGia
            // 
            this.colDonGia.HeaderText = "Đơn giá";
            this.colDonGia.MinimumWidth = 6;
            this.colDonGia.Name = "colDonGia";
            this.colDonGia.Width = 125;
            // 
            // colTinhTrang
            // 
            this.colTinhTrang.HeaderText = "Tình trạng";
            this.colTinhTrang.MinimumWidth = 6;
            this.colTinhTrang.Name = "colTinhTrang";
            this.colTinhTrang.Width = 125;
            // 
            // colNhaSanXuat
            // 
            this.colNhaSanXuat.HeaderText = "Nhà sản xuất";
            this.colNhaSanXuat.MinimumWidth = 6;
            this.colNhaSanXuat.Name = "colNhaSanXuat";
            this.colNhaSanXuat.Width = 125;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(16, 47);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(100, 28);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // comboBoxLoaiLinhKien
            // 
            this.comboBoxLoaiLinhKien.FormattingEnabled = true;
            this.comboBoxLoaiLinhKien.Location = new System.Drawing.Point(176, 49);
            this.comboBoxLoaiLinhKien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxLoaiLinhKien.Name = "comboBoxLoaiLinhKien";
            this.comboBoxLoaiLinhKien.Size = new System.Drawing.Size(160, 24);
            this.comboBoxLoaiLinhKien.TabIndex = 3;
            // 
            // lbLoaiLinhKien
            // 
            this.lbLoaiLinhKien.AutoSize = true;
            this.lbLoaiLinhKien.Location = new System.Drawing.Point(116, 53);
            this.lbLoaiLinhKien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLoaiLinhKien.Name = "lbLoaiLinhKien";
            this.lbLoaiLinhKien.Size = new System.Drawing.Size(56, 17);
            this.lbLoaiLinhKien.TabIndex = 4;
            this.lbLoaiLinhKien.Text = "Loại LK";
            // 
            // lbTenLinhKien
            // 
            this.lbTenLinhKien.AutoSize = true;
            this.lbTenLinhKien.Location = new System.Drawing.Point(343, 53);
            this.lbTenLinhKien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTenLinhKien.Name = "lbTenLinhKien";
            this.lbTenLinhKien.Size = new System.Drawing.Size(54, 17);
            this.lbTenLinhKien.TabIndex = 6;
            this.lbTenLinhKien.Text = "Tên LK";
            // 
            // txtTenLinhKien
            // 
            this.txtTenLinhKien.Location = new System.Drawing.Point(401, 49);
            this.txtTenLinhKien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenLinhKien.Name = "txtTenLinhKien";
            this.txtTenLinhKien.Size = new System.Drawing.Size(132, 22);
            this.txtTenLinhKien.TabIndex = 7;
            // 
            // lbDanhMucSanPham
            // 
            this.lbDanhMucSanPham.AutoSize = true;
            this.lbDanhMucSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDanhMucSanPham.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbDanhMucSanPham.Location = new System.Drawing.Point(16, 162);
            this.lbDanhMucSanPham.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDanhMucSanPham.Name = "lbDanhMucSanPham";
            this.lbDanhMucSanPham.Size = new System.Drawing.Size(214, 26);
            this.lbDanhMucSanPham.TabIndex = 8;
            this.lbDanhMucSanPham.Text = "Danh mục sản phẩm";
            // 
            // btnQuanLyDanhMuc
            // 
            this.btnQuanLyDanhMuc.Location = new System.Drawing.Point(747, 151);
            this.btnQuanLyDanhMuc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnQuanLyDanhMuc.Name = "btnQuanLyDanhMuc";
            this.btnQuanLyDanhMuc.Size = new System.Drawing.Size(151, 34);
            this.btnQuanLyDanhMuc.TabIndex = 9;
            this.btnQuanLyDanhMuc.Text = "Quản lý danh mục";
            this.btnQuanLyDanhMuc.UseVisualStyleBackColor = true;
            this.btnQuanLyDanhMuc.Click += new System.EventHandler(this.btnQuanLyDanhMuc_Click);
            // 
            // btnDatHang
            // 
            this.btnDatHang.Location = new System.Drawing.Point(588, 151);
            this.btnDatHang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDatHang.Name = "btnDatHang";
            this.btnDatHang.Size = new System.Drawing.Size(151, 34);
            this.btnDatHang.TabIndex = 10;
            this.btnDatHang.Text = "Đặt hàng";
            this.btnDatHang.UseVisualStyleBackColor = true;
            this.btnDatHang.Click += new System.EventHandler(this.btnDatHang_Click);
            // 
            // txtMaNguoiDung
            // 
            this.txtMaNguoiDung.Location = new System.Drawing.Point(133, 95);
            this.txtMaNguoiDung.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaNguoiDung.Name = "txtMaNguoiDung";
            this.txtMaNguoiDung.Size = new System.Drawing.Size(203, 22);
            this.txtMaNguoiDung.TabIndex = 12;
            // 
            // lbMaNguoiDung
            // 
            this.lbMaNguoiDung.AutoSize = true;
            this.lbMaNguoiDung.Location = new System.Drawing.Point(12, 98);
            this.lbMaNguoiDung.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMaNguoiDung.Name = "lbMaNguoiDung";
            this.lbMaNguoiDung.Size = new System.Drawing.Size(106, 17);
            this.lbMaNguoiDung.TabIndex = 11;
            this.lbMaNguoiDung.Text = "Mã người dùng:";
            // 
            // txtTenNguoiDung
            // 
            this.txtTenNguoiDung.Location = new System.Drawing.Point(499, 95);
            this.txtTenNguoiDung.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenNguoiDung.Name = "txtTenNguoiDung";
            this.txtTenNguoiDung.Size = new System.Drawing.Size(203, 22);
            this.txtTenNguoiDung.TabIndex = 14;
            // 
            // lbTenNguoiDung
            // 
            this.lbTenNguoiDung.AutoSize = true;
            this.lbTenNguoiDung.Location = new System.Drawing.Point(377, 98);
            this.lbTenNguoiDung.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTenNguoiDung.Name = "lbTenNguoiDung";
            this.lbTenNguoiDung.Size = new System.Drawing.Size(112, 17);
            this.lbTenNguoiDung.TabIndex = 13;
            this.lbTenNguoiDung.Text = "Tên người dùng:";
            // 
            // MHChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 331);
            this.Controls.Add(this.txtTenNguoiDung);
            this.Controls.Add(this.lbTenNguoiDung);
            this.Controls.Add(this.txtMaNguoiDung);
            this.Controls.Add(this.lbMaNguoiDung);
            this.Controls.Add(this.btnDatHang);
            this.Controls.Add(this.btnQuanLyDanhMuc);
            this.Controls.Add(this.lbDanhMucSanPham);
            this.Controls.Add(this.txtTenLinhKien);
            this.Controls.Add(this.lbTenLinhKien);
            this.Controls.Add(this.lbLoaiLinhKien);
            this.Controls.Add(this.comboBoxLoaiLinhKien);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.gvDanhMucSanPham);
            this.Controls.Add(this.toolStrip);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MHChinh";
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhMucSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripLabel toolStripLabelDangNhap;
        private System.Windows.Forms.DataGridView gvDanhMucSanPham;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.ComboBox comboBoxLoaiLinhKien;
        private System.Windows.Forms.Label lbLoaiLinhKien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaLinhKien; 
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenLinhKien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoaiLinhKien; 
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGia; 
        private System.Windows.Forms.DataGridViewTextBoxColumn colTinhTrang; 
        private System.Windows.Forms.DataGridViewTextBoxColumn colNhaSanXuat; 
        private System.Windows.Forms.Label lbTenLinhKien;
        private System.Windows.Forms.TextBox txtTenLinhKien;
        private System.Windows.Forms.Label lbDanhMucSanPham;
        private System.Windows.Forms.Button btnQuanLyDanhMuc;
        private System.Windows.Forms.Button btnDatHang;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.TextBox txtMaNguoiDung;
        private System.Windows.Forms.Label lbMaNguoiDung;
        private System.Windows.Forms.TextBox txtTenNguoiDung;
        private System.Windows.Forms.Label lbTenNguoiDung;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonMenu;
        private System.Windows.Forms.ToolStripMenuItem thongTinTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem dangXuatToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenLK;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoaiLK;
    }
}

