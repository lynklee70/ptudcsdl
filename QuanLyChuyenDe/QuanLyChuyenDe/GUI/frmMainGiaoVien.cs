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
    public partial class frmMainGiaoVien : Form
    {
        public string MaGV = "";
        public frmMainGiaoVien()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
        }

        public frmMainGiaoVien(string magv)
        {
            InitializeComponent();
            MaGV = magv;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            frmCapNhatThongTin frm = new frmCapNhatThongTin(MaGV);
            frm.ShowDialog();
        }


        private void btnCDPT_Click(object sender, EventArgs e)
        {
            frmPhuTrachChuyenDe frm = new frmPhuTrachChuyenDe(MaGV);
            frm.ShowDialog();
        }

        private void frmMainGiaoVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCapNhatThongTin_Click(object sender, EventArgs e)
        {
            frmCapNhatThongTin frm = new frmCapNhatThongTin();
            frm.ShowDialog();
        }

        private void btnGuiChuyenDe_Click(object sender, EventArgs e)
        {
            frmPhuTrachChuyenDe frm = new frmPhuTrachChuyenDe();
            frm.ShowDialog();
        }
    }
}
