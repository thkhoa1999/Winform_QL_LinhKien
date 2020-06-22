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
    public partial class MHDuyet : Form
    {
        MHQuanLy backup;
        public MHDuyet(MHQuanLy back)
        {
            InitializeComponent();
            backup = back;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            backup.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MHHoaDon HD = new MHHoaDon();
            HD.Show();
        }
    }
}
