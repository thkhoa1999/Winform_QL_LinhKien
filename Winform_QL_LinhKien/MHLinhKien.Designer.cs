namespace Winform_QL_LinhKien
{
    partial class MHLinhKien
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
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.lbDonGia = new System.Windows.Forms.Label();
            this.txtLoaiLinhKien = new System.Windows.Forms.TextBox();
            this.lbLoaiLinhKien = new System.Windows.Forms.Label();
            this.txtTenLinhKien = new System.Windows.Forms.TextBox();
            this.lbTenLinhKien = new System.Windows.Forms.Label();
            this.txtMaLinhKien = new System.Windows.Forms.TextBox();
            this.lbMaLinhKien = new System.Windows.Forms.Label();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonQuayLai = new System.Windows.Forms.ToolStripButton();
            this.txtSoLuongTon = new System.Windows.Forms.TextBox();
            this.lbSoLuongTon = new System.Windows.Forms.Label();
            this.gvLinhKien = new System.Windows.Forms.DataGridView();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaLinhKien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenLinhKien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoaiLinhKien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuongTon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThemLinhKien = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnNhapHang = new System.Windows.Forms.Button();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvLinhKien)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(164, 157);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(218, 20);
            this.txtDonGia.TabIndex = 40;
            // 
            // lbDonGia
            // 
            this.lbDonGia.AutoSize = true;
            this.lbDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDonGia.Location = new System.Drawing.Point(81, 155);
            this.lbDonGia.Name = "lbDonGia";
            this.lbDonGia.Size = new System.Drawing.Size(77, 22);
            this.lbDonGia.TabIndex = 39;
            this.lbDonGia.Text = "Đơn giá:";
            // 
            // txtLoaiLinhKien
            // 
            this.txtLoaiLinhKien.Location = new System.Drawing.Point(164, 117);
            this.txtLoaiLinhKien.Name = "txtLoaiLinhKien";
            this.txtLoaiLinhKien.Size = new System.Drawing.Size(218, 20);
            this.txtLoaiLinhKien.TabIndex = 38;
            // 
            // lbLoaiLinhKien
            // 
            this.lbLoaiLinhKien.AutoSize = true;
            this.lbLoaiLinhKien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoaiLinhKien.Location = new System.Drawing.Point(38, 115);
            this.lbLoaiLinhKien.Name = "lbLoaiLinhKien";
            this.lbLoaiLinhKien.Size = new System.Drawing.Size(120, 22);
            this.lbLoaiLinhKien.TabIndex = 37;
            this.lbLoaiLinhKien.Text = "Loại linh kiện:";
            // 
            // txtTenLinhKien
            // 
            this.txtTenLinhKien.Location = new System.Drawing.Point(164, 81);
            this.txtTenLinhKien.Name = "txtTenLinhKien";
            this.txtTenLinhKien.Size = new System.Drawing.Size(218, 20);
            this.txtTenLinhKien.TabIndex = 36;
            // 
            // lbTenLinhKien
            // 
            this.lbTenLinhKien.AutoSize = true;
            this.lbTenLinhKien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenLinhKien.Location = new System.Drawing.Point(40, 79);
            this.lbTenLinhKien.Name = "lbTenLinhKien";
            this.lbTenLinhKien.Size = new System.Drawing.Size(118, 22);
            this.lbTenLinhKien.TabIndex = 35;
            this.lbTenLinhKien.Text = "Tên linh kiện:";
            // 
            // txtMaLinhKien
            // 
            this.txtMaLinhKien.Location = new System.Drawing.Point(164, 41);
            this.txtMaLinhKien.Name = "txtMaLinhKien";
            this.txtMaLinhKien.Size = new System.Drawing.Size(218, 20);
            this.txtMaLinhKien.TabIndex = 34;
            // 
            // lbMaLinhKien
            // 
            this.lbMaLinhKien.AutoSize = true;
            this.lbMaLinhKien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaLinhKien.Location = new System.Drawing.Point(42, 39);
            this.lbMaLinhKien.Name = "lbMaLinhKien";
            this.lbMaLinhKien.Size = new System.Drawing.Size(110, 22);
            this.lbMaLinhKien.TabIndex = 33;
            this.lbMaLinhKien.Text = "Mã linh kiện:";
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonQuayLai});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip.Size = new System.Drawing.Size(775, 25);
            this.toolStrip.TabIndex = 32;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripButtonQuayLai
            // 
            this.toolStripButtonQuayLai.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonQuayLai.Image = global::Winform_QL_LinhKien.Properties.Resources._return;
            this.toolStripButtonQuayLai.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonQuayLai.Name = "toolStripButtonQuayLai";
            this.toolStripButtonQuayLai.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonQuayLai.Text = "toolStripButton1";
            this.toolStripButtonQuayLai.Click += new System.EventHandler(this.toolStripButtonQuayLai_Click);
            // 
            // txtSoLuongTon
            // 
            this.txtSoLuongTon.Location = new System.Drawing.Point(549, 172);
            this.txtSoLuongTon.Name = "txtSoLuongTon";
            this.txtSoLuongTon.Size = new System.Drawing.Size(205, 20);
            this.txtSoLuongTon.TabIndex = 42;
            // 
            // lbSoLuongTon
            // 
            this.lbSoLuongTon.AutoSize = true;
            this.lbSoLuongTon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoLuongTon.Location = new System.Drawing.Point(427, 170);
            this.lbSoLuongTon.Name = "lbSoLuongTon";
            this.lbSoLuongTon.Size = new System.Drawing.Size(116, 22);
            this.lbSoLuongTon.TabIndex = 41;
            this.lbSoLuongTon.Text = "Số lượng tồn:";
            // 
            // gvLinhKien
            // 
            this.gvLinhKien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvLinhKien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.colMaLinhKien,
            this.colTenLinhKien,
            this.colLoaiLinhKien,
            this.colDonGia,
            this.colSoLuongTon});
            this.gvLinhKien.Location = new System.Drawing.Point(46, 210);
            this.gvLinhKien.Name = "gvLinhKien";
            this.gvLinhKien.Size = new System.Drawing.Size(708, 198);
            this.gvLinhKien.TabIndex = 43;
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
            this.colTenLinhKien.HeaderText = "Tên LK";
            this.colTenLinhKien.Name = "colTenLinhKien";
            // 
            // colLoaiLinhKien
            // 
            this.colLoaiLinhKien.HeaderText = "Loại LK";
            this.colLoaiLinhKien.Name = "colLoaiLinhKien";
            // 
            // colDonGia
            // 
            this.colDonGia.HeaderText = "Đơn giá";
            this.colDonGia.Name = "colDonGia";
            // 
            // colSoLuongTon
            // 
            this.colSoLuongTon.HeaderText = "Số lượng tồn";
            this.colSoLuongTon.Name = "colSoLuongTon";
            // 
            // btnThemLinhKien
            // 
            this.btnThemLinhKien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemLinhKien.Location = new System.Drawing.Point(426, 41);
            this.btnThemLinhKien.Name = "btnThemLinhKien";
            this.btnThemLinhKien.Size = new System.Drawing.Size(161, 34);
            this.btnThemLinhKien.TabIndex = 44;
            this.btnThemLinhKien.Text = "Thêm linh kiện";
            this.btnThemLinhKien.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(426, 81);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(161, 34);
            this.btnTimKiem.TabIndex = 45;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(426, 121);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(161, 34);
            this.btnLuu.TabIndex = 46;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(593, 41);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(161, 34);
            this.btnSua.TabIndex = 47;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(593, 81);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(161, 34);
            this.btnXoa.TabIndex = 48;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnNhapHang
            // 
            this.btnNhapHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapHang.Location = new System.Drawing.Point(593, 121);
            this.btnNhapHang.Name = "btnNhapHang";
            this.btnNhapHang.Size = new System.Drawing.Size(161, 34);
            this.btnNhapHang.TabIndex = 49;
            this.btnNhapHang.Text = "Nhập hàng";
            this.btnNhapHang.UseVisualStyleBackColor = true;
            this.btnNhapHang.Click += new System.EventHandler(this.btnNhapHang_Click);
            // 
            // MhLinhKien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 429);
            this.Controls.Add(this.btnNhapHang);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnThemLinhKien);
            this.Controls.Add(this.gvLinhKien);
            this.Controls.Add(this.txtSoLuongTon);
            this.Controls.Add(this.lbSoLuongTon);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.lbDonGia);
            this.Controls.Add(this.txtLoaiLinhKien);
            this.Controls.Add(this.lbLoaiLinhKien);
            this.Controls.Add(this.txtTenLinhKien);
            this.Controls.Add(this.lbTenLinhKien);
            this.Controls.Add(this.txtMaLinhKien);
            this.Controls.Add(this.lbMaLinhKien);
            this.Controls.Add(this.toolStrip);
            this.Name = "MhLinhKien";
            this.Text = "LINH KIỆN";
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvLinhKien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label lbDonGia;
        private System.Windows.Forms.TextBox txtLoaiLinhKien;
        private System.Windows.Forms.Label lbLoaiLinhKien;
        private System.Windows.Forms.TextBox txtTenLinhKien;
        private System.Windows.Forms.Label lbTenLinhKien;
        private System.Windows.Forms.TextBox txtMaLinhKien;
        private System.Windows.Forms.Label lbMaLinhKien;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButtonQuayLai;
        private System.Windows.Forms.TextBox txtSoLuongTon;
        private System.Windows.Forms.Label lbSoLuongTon;
        private System.Windows.Forms.DataGridView gvLinhKien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaLinhKien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenLinhKien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoaiLinhKien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuongTon;
        private System.Windows.Forms.Button btnThemLinhKien;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnNhapHang;
    }
}