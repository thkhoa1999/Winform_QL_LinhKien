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
    public partial class MHDangKy : Form
    {
        MHDangNhap backup;
        public MHDangKy(MHDangNhap back)
        {
            InitializeComponent();
            backup = back;
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            backup.Show();
        }

        private void MHDangKy_Load(object sender, EventArgs e)
        {

        }
    }
}
