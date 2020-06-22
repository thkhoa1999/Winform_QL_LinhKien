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
    public partial class MHDatHang : Form
    {
        MHChinh backup;
        public MHDatHang(MHChinh back)
        {
            InitializeComponent();
            backup = back;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            MHXacNhan XN = new MHXacNhan(backup);
            this.Hide();
            XN.Show();
        }

        private void toolStripButtonQuayLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            backup.Show();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            MHTimKiemDatHang TK = new MHTimKiemDatHang();
            TK.Show();
        }
    }
}
