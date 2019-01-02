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
    public partial class frmMainGiaoVien : Form
    {
        public string MaGV = "";
        public frmMainGiaoVien()
        {
            InitializeComponent();
        }

        public frmMainGiaoVien(string magv)
        {
            InitializeComponent();
            MaGV = magv;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            frmCapNhatThongTin frm = new frmCapNhatThongTin(MaGV);
            frm.ShowDialog();
        }
    }
}
