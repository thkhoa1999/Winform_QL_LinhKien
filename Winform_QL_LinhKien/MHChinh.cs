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
    public partial class MHChinh : Form
    {
        public MHChinh()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            MHDangNhap DN = new MHDangNhap(this);
            this.Hide();
            DN.Show();
        }

        private void btnDatHang_Click(object sender, EventArgs e)
        {
            MHDatHang DH = new MHDatHang(this);
            this.Hide();
            DH.Show();
        }

        private void thongTinTaiKhoan_Click(object sender, EventArgs e)
        {
            MHThongTin info = new MHThongTin(this);
            this.Hide();
            info.Show();
        }

        private void btnQuanLyDanhMuc_Click(object sender, EventArgs e)
        {
            MHQuanLy QL = new MHQuanLy(this);
            this.Hide();
            QL.Show();
        }
    }
}
