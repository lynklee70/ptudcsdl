using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08_18
{
    public partial class frmMainGiaoVu : Form
    {
        public frmMainGiaoVu()
        {
            InitializeComponent();
        }

        private void btnTaoTK_Click(object sender, EventArgs e)
        {
            frmDangKyTaiKhoan frm = new frmDangKyTaiKhoan();
            frm.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDanhSachCD_Click(object sender, EventArgs e)
        {
            frmListMonHoc frm = new frmListMonHoc();
            frm.ShowDialog();
        }
    }
}
