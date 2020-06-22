namespace Winform_QL_LinhKien
{
    partial class MHTimKiemDatHang
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
            this.lbMaLinhKien = new System.Windows.Forms.Label();
            this.txtMaLinhKien = new System.Windows.Forms.TextBox();
            this.txtTenLinhKien = new System.Windows.Forms.TextBox();
            this.lbTenLinhKien = new System.Windows.Forms.Label();
            this.lbLoaiLinhKien = new System.Windows.Forms.Label();
            this.comboBoxLoaiLinhKien = new System.Windows.Forms.ComboBox();
            this.comboBoxNhaSanXuat = new System.Windows.Forms.ComboBox();
            this.lbNhaSanXuat = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.lbGia = new System.Windows.Forms.Label();
            this.txtDen = new System.Windows.Forms.TextBox();
            this.lbDen = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.gvTimKiemDatHang = new System.Windows.Forms.DataGridView();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaLinhKien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenLinhKien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoaiLinhKien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNhaSanXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvTimKiemDatHang)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMaLinhKien
            // 
            this.lbMaLinhKien.AutoSize = true;
            this.lbMaLinhKien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaLinhKien.Location = new System.Drawing.Point(36, 27);
            this.lbMaLinhKien.Name = "lbMaLinhKien";
            this.lbMaLinhKien.Size = new System.Drawing.Size(66, 22);
            this.lbMaLinhKien.TabIndex = 0;
            this.lbMaLinhKien.Text = "Mã LK:";
            // 
            // txtMaLinhKien
            // 
            this.txtMaLinhKien.Location = new System.Drawing.Point(108, 29);
            this.txtMaLinhKien.Name = "txtMaLinhKien";
            this.txtMaLinhKien.Size = new System.Drawing.Size(100, 20);
            this.txtMaLinhKien.TabIndex = 1;
            // 
            // txtTenLinhKien
            // 
            this.txtTenLinhKien.Location = new System.Drawing.Point(108, 77);
            this.txtTenLinhKien.Name = "txtTenLinhKien";
            this.txtTenLinhKien.Size = new System.Drawing.Size(100, 20);
            this.txtTenLinhKien.TabIndex = 3;
            // 
            // lbTenLinhKien
            // 
            this.lbTenLinhKien.AutoSize = true;
            this.lbTenLinhKien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenLinhKien.Location = new System.Drawing.Point(28, 75);
            this.lbTenLinhKien.Name = "lbTenLinhKien";
            this.lbTenLinhKien.Size = new System.Drawing.Size(74, 22);
            this.lbTenLinhKien.TabIndex = 2;
            this.lbTenLinhKien.Text = "Tên LK:";
            // 
            // lbLoaiLinhKien
            // 
            this.lbLoaiLinhKien.AutoSize = true;
            this.lbLoaiLinhKien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoaiLinhKien.Location = new System.Drawing.Point(302, 27);
            this.lbLoaiLinhKien.Name = "lbLoaiLinhKien";
            this.lbLoaiLinhKien.Size = new System.Drawing.Size(76, 22);
            this.lbLoaiLinhKien.TabIndex = 4;
            this.lbLoaiLinhKien.Text = "Loại LK:";
            // 
            // comboBoxLoaiLinhKien
            // 
            this.comboBoxLoaiLinhKien.FormattingEnabled = true;
            this.comboBoxLoaiLinhKien.Location = new System.Drawing.Point(384, 27);
            this.comboBoxLoaiLinhKien.Name = "comboBoxLoaiLinhKien";
            this.comboBoxLoaiLinhKien.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLoaiLinhKien.TabIndex = 5;
            // 
            // comboBoxNhaSanXuat
            // 
            this.comboBoxNhaSanXuat.FormattingEnabled = true;
            this.comboBoxNhaSanXuat.Location = new System.Drawing.Point(384, 77);
            this.comboBoxNhaSanXuat.Name = "comboBoxNhaSanXuat";
            this.comboBoxNhaSanXuat.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNhaSanXuat.TabIndex = 7;
            // 
            // lbNhaSanXuat
            // 
            this.lbNhaSanXuat.AutoSize = true;
            this.lbNhaSanXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNhaSanXuat.Location = new System.Drawing.Point(257, 75);
            this.lbNhaSanXuat.Name = "lbNhaSanXuat";
            this.lbNhaSanXuat.Size = new System.Drawing.Size(121, 22);
            this.lbNhaSanXuat.TabIndex = 6;
            this.lbNhaSanXuat.Text = "Nhà sản xuất:";
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(108, 121);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(100, 20);
            this.txtGia.TabIndex = 9;
            // 
            // lbGia
            // 
            this.lbGia.AutoSize = true;
            this.lbGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGia.Location = new System.Drawing.Point(59, 119);
            this.lbGia.Name = "lbGia";
            this.lbGia.Size = new System.Drawing.Size(43, 22);
            this.lbGia.TabIndex = 8;
            this.lbGia.Text = "Giá:";
            // 
            // txtDen
            // 
            this.txtDen.Location = new System.Drawing.Point(260, 121);
            this.txtDen.Name = "txtDen";
            this.txtDen.Size = new System.Drawing.Size(100, 20);
            this.txtDen.TabIndex = 11;
            // 
            // lbDen
            // 
            this.lbDen.AutoSize = true;
            this.lbDen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDen.Location = new System.Drawing.Point(211, 119);
            this.lbDen.Name = "lbDen";
            this.lbDen.Size = new System.Drawing.Size(48, 22);
            this.lbDen.TabIndex = 10;
            this.lbDen.Text = "Đến:";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(580, 103);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(168, 38);
            this.btnTimKiem.TabIndex = 12;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // gvTimKiemDatHang
            // 
            this.gvTimKiemDatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvTimKiemDatHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.colMaLinhKien,
            this.colTenLinhKien,
            this.colLoaiLinhKien,
            this.colNhaSanXuat,
            this.colDonGia,
            this.colTinhTrang});
            this.gvTimKiemDatHang.Location = new System.Drawing.Point(32, 171);
            this.gvTimKiemDatHang.Name = "gvTimKiemDatHang";
            this.gvTimKiemDatHang.Size = new System.Drawing.Size(716, 169);
            this.gvTimKiemDatHang.TabIndex = 13;
            // 
            // colSTT
            // 
            this.colSTT.HeaderText = "STT";
            this.colSTT.Name = "colSTT";
            // 
            // colMaLinhKien
            // 
            this.colMaLinhKien.HeaderText = "Mã LK";
            this.colMaLinhKien.Name = "colMaLinhKien";
            // 
            // colTenLinhKien
            // 
            this.colTenLinhKien.HeaderText = "Tên linh kiện";
            this.colTenLinhKien.Name = "colTenLinhKien";
            // 
            // colLoaiLinhKien
            // 
            this.colLoaiLinhKien.HeaderText = "Loại linh kiện";
            this.colLoaiLinhKien.Name = "colLoaiLinhKien";
            // 
            // colNhaSanXuat
            // 
            this.colNhaSanXuat.HeaderText = "Nhà sản xuất";
            this.colNhaSanXuat.Name = "colNhaSanXuat";
            // 
            // colDonGia
            // 
            this.colDonGia.HeaderText = "Đơn giá";
            this.colDonGia.Name = "colDonGia";
            // 
            // colTinhTrang
            // 
            this.colTinhTrang.HeaderText = "Tình trạng";
            this.colTinhTrang.Name = "colTinhTrang";
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(580, 352);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(146, 38);
            this.btnThem.TabIndex = 16;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(419, 352);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(146, 38);
            this.btnHuy.TabIndex = 17;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // MHTimKiemDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 402);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.gvTimKiemDatHang);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtDen);
            this.Controls.Add(this.lbDen);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.lbGia);
            this.Controls.Add(this.comboBoxNhaSanXuat);
            this.Controls.Add(this.lbNhaSanXuat);
            this.Controls.Add(this.comboBoxLoaiLinhKien);
            this.Controls.Add(this.lbLoaiLinhKien);
            this.Controls.Add(this.txtTenLinhKien);
            this.Controls.Add(this.lbTenLinhKien);
            this.Controls.Add(this.txtMaLinhKien);
            this.Controls.Add(this.lbMaLinhKien);
            this.Name = "MHTimKiemDatHang";
            this.Text = "TÌM KIẾM ĐẶT HÀNG";
            ((System.ComponentModel.ISupportInitialize)(this.gvTimKiemDatHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMaLinhKien;
        private System.Windows.Forms.TextBox txtMaLinhKien;
        private System.Windows.Forms.TextBox txtTenLinhKien;
        private System.Windows.Forms.Label lbTenLinhKien;
        private System.Windows.Forms.Label lbLoaiLinhKien;
        private System.Windows.Forms.ComboBox comboBoxLoaiLinhKien;
        private System.Windows.Forms.ComboBox comboBoxNhaSanXuat;
        private System.Windows.Forms.Label lbNhaSanXuat;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label lbGia;
        private System.Windows.Forms.TextBox txtDen;
        private System.Windows.Forms.Label lbDen;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView gvTimKiemDatHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT; 
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaLinhKien; 
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenLinhKien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoaiLinhKien; 
        private System.Windows.Forms.DataGridViewTextBoxColumn colNhaSanXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGia; 
        private System.Windows.Forms.DataGridViewTextBoxColumn colTinhTrang; 
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnHuy;
    }
}