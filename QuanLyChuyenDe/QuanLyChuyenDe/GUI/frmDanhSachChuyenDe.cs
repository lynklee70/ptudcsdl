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
    public partial class frmDanhSachChuyenDe : Form
    {
        public frmDanhSachChuyenDe()
        {
            InitializeComponent();
        }

        private void frmDanhSachChuyenDe_Load(object sender, EventArgs e)
        {
            ChuyenDeBUS.Instance.loadFormDanhSach(dgvDanhSachCD);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemChuyenDe frm = new frmThemChuyenDe();
            frm.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string macd = dgvDanhSachCD.SelectedRows[0].Cells["MaCD"].Value.ToString();
            frmCapNhatChuyenDe frm = new frmCapNhatChuyenDe(macd);
            frm.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(ChuyenDeBUS.Instance.delete(dgvDanhSachCD))
            {
                MessageBox.Show("Xóa thành công", "Thông báo");
                ChuyenDeBUS.Instance.loadFormDanhSach(dgvDanhSachCD);
            }
            else
            {
                MessageBox.Show("Xóa thất bại", "Thông báo");
            }
        }
    }
}
