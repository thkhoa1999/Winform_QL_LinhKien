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
    public partial class MHQuyDinh : Form
    {
        MHDanhMuc backup;
        public MHQuyDinh(MHDanhMuc back)
        {
            InitializeComponent();
            backup = back;
        }

        private void toolStripButtonQuayLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            backup.Show();
        }
    }
}
