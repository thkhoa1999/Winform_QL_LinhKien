namespace Winform_QL_LinhKien
{
    partial class MHXacNhan
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
            this.btnLapPhieuDatHang = new System.Windows.Forms.Button();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.gvXacNhan = new System.Windows.Forms.DataGridView();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaLinhKien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenLinhKien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvXacNhan)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLapPhieuDatHang
            // 
            this.btnLapPhieuDatHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLapPhieuDatHang.Location = new System.Drawing.Point(12, 273);
            this.btnLapPhieuDatHang.Name = "btnLapPhieuDatHang";
            this.btnLapPhieuDatHang.Size = new System.Drawing.Size(209, 31);
            this.btnLapPhieuDatHang.TabIndex = 23;
            this.btnLapPhieuDatHang.Text = "Lập phiếu đặt hàng";
            this.btnLapPhieuDatHang.UseVisualStyleBackColor = true;
            this.btnLapPhieuDatHang.Click += new System.EventHandler(this.OK_Click);
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(635, 280);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(133, 20);
            this.txtTongTien.TabIndex = 22;
            // 
            // lbTongTien
            // 
            this.lbTongTien.AutoSize = true;
            this.lbTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongTien.Location = new System.Drawing.Point(538, 278);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(91, 22);
            this.lbTongTien.TabIndex = 21;
            this.lbTongTien.Text = "Tổng tiền:";
            // 
            // gvXacNhan
            // 
            this.gvXacNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvXacNhan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.colMaLinhKien,
            this.colTenLinhKien,
            this.colSoLuong,
            this.colThanhTien});
            this.gvXacNhan.Location = new System.Drawing.Point(12, 38);
            this.gvXacNhan.Name = "gvXacNhan";
            this.gvXacNhan.Size = new System.Drawing.Size(756, 214);
            this.gvXacNhan.TabIndex = 20;
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
            // colSoLuong
            // 
            this.colSoLuong.HeaderText = "Số lượng";
            this.colSoLuong.Name = "colSoLuong";
            // 
            // colThanhTien
            // 
            this.colThanhTien.HeaderText = "Thành tiền";
            this.colThanhTien.Name = "colThanhTien";
            // 
            // MHXacNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 330);
            this.Controls.Add(this.btnLapPhieuDatHang);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.lbTongTien);
            this.Controls.Add(this.gvXacNhan);
            this.Name = "MHXacNhan";
            this.Text = "XÁC NHẬN";
            ((System.ComponentModel.ISupportInitialize)(this.gvXacNhan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLapPhieuDatHang;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label lbTongTien;
        private System.Windows.Forms.DataGridView gvXacNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaLinhKien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenLinhKien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThanhTien;
    }
}