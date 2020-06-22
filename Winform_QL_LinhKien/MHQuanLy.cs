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
    public partial class MHQuanLy : Form
    {
        MHChinh backup;
        public MHQuanLy(MHChinh back)
        {
            InitializeComponent();
            backup = back;
        }

        private void toolStripButtonQuayLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            backup.Show();
        }

        private void btnQuanLyDanhMuc_Click(object sender, EventArgs e)
        {
            MHDanhMuc DM = new MHDanhMuc(this);
            this.Hide();
            DM.Show();
        }

        private void btnDuyetDonHang_Click(object sender, EventArgs e)
        {
            MHDuyet D = new MHDuyet(this);
            this.Hide();
            D.Show();
        }
    }
}
