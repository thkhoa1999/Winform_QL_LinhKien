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
    public partial class MHDangNhap : Form
    {
        MHChinh backup;
        public MHDangNhap(MHChinh back)
        {
            InitializeComponent();
            backup = back;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            this.Hide();
            backup.Show();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            this.Hide();
            MHDangKy DK = new MHDangKy(this);
            DK.Show();
        }

        private void toolStripButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            backup.Show();
        }
    }
}
