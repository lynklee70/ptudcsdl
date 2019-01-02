using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyChuyenDe.BUS;

namespace QuanLyChuyenDe.GUI
{
    public partial class frmThemChuyenDe : Form
    {
        public frmThemChuyenDe()
        {
            InitializeComponent();
        }

        private void txtSLSVToiDa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSLNhomToiDa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void frmThemChuyenDe_Load(object sender, EventArgs e)
        {
            ChuyenDeBUS.Instance.loadFormThem(this);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtpNgayBD_ValueChanged(object sender, EventArgs e)
        {
            ChuyenDeBUS.Instance.ngayBDValueChange(dtpNgayBD, dtpNgayKT);
        }

        private void dtpNgayKT_ValueChanged(object sender, EventArgs e)
        {
            ChuyenDeBUS.Instance.ngayKTValueChange(dtpNgayBD, dtpNgayKT);
        }
    }
}
