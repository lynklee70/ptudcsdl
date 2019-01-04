using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyChuyenDe.GUI
{
    public partial class frmMainGiaoVu : Form
    {
        public frmMainGiaoVu()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
        }

        private void frmMainGiaoVu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnQuanLyChuyenDe_Click(object sender, EventArgs e)
        {
            frmDanhSachChuyenDe frm = new frmDanhSachChuyenDe();
            frm.ShowDialog();
        }

        private void btnTaoTaiKhoan_Click(object sender, EventArgs e)
        {
            frmDangKyTaiKhoan frm = new frmDangKyTaiKhoan();
            frm.ShowDialog();
        }

        private void btnTraCuKQDK_Click(object sender, EventArgs e)
        {
            frmTraCuuKetQuaChuyenDe frm = new frmTraCuuKetQuaChuyenDe();
            frm.ShowDialog();
        }

        private void btnTraCuuDiem_Click(object sender, EventArgs e)
        {
            frmTraCuuKetQuaChuyenDe frm = new frmTraCuuKetQuaChuyenDe();
            frm.ShowDialog();
        }
    }
}
