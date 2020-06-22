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
    public partial class MHLinhKien : Form
    {
        MHDanhMuc backup;
        public MHLinhKien(MHDanhMuc back)
        {
            InitializeComponent();
            backup = back;
        }

        private void toolStripButtonQuayLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            backup.Show();
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            MHNhap nhap = new MHNhap();
            nhap.Show();
        }
    }
}
