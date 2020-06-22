using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_QL_LinhKien
{
    public partial class MHDanhMuc : Form
    {
        MHQuanLy backup;
        public MHDanhMuc(MHQuanLy back)
        {
            InitializeComponent();
            backup = back;
        }

        private void toolStripButtonQuayLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            backup.Show();
        }

        private void btnDanhMucLinhKien_Click(object sender, EventArgs e)
        {
            MHLinhKien LK = new MHLinhKien(this);
            this.Hide();
            LK.Show();
        }

        private void btnDanhMucNSX_Click(object sender, EventArgs e)
        {
            MHNhaSanXuat NSX = new MHNhaSanXuat(this);
            this.Hide();
            NSX.Show();
        }

        private void btnDanhMucNCC_Click(object sender, EventArgs e)
        {
            MHNhaCungCap NCC = new MHNhaCungCap(this);
            this.Hide();
            NCC.Show();
        }

        private void btnCacQuyDinh_Click(object sender, EventArgs e)
        {
            MHQuyDinh QD = new MHQuyDinh(this);
            this.Hide();
            QD.Show();
        }
    }
}
