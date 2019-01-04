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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
        }

        private void frmDanhSachChuyenDe_Load(object sender, EventArgs e)
        {
            load();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemChuyenDe frm = new frmThemChuyenDe();
            frm.WindowClosed += load;
            frm.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachCD.SelectedRows.Count > 0)
            {
                string macd = dgvDanhSachCD.SelectedRows[0].Cells["MaCD"].Value.ToString();
                frmCapNhatChuyenDe frm = new frmCapNhatChuyenDe(macd);
                frm.WindowClosed += load;
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Không có dữ liệu", "Thông báo");
            }
        }

        private void load()
        {
            ChuyenDeBUS.Instance.loadFormDanhSach(dgvDanhSachCD);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachCD.SelectedRows.Count > 0)
            {
                string macd = dgvDanhSachCD.SelectedRows[0].Cells["MaCD"].Value.ToString();
                if (ChuyenDeBUS.Instance.delete(macd))
                {
                    MessageBox.Show("Xóa thành công", "Thông báo");
                    ChuyenDeBUS.Instance.loadFormDanhSach(dgvDanhSachCD);
                }
                else
                {
                    MessageBox.Show("Xóa thất bại! Chuyên đề đã được sinh viên đăng kí hoặc được mở lớp!", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu", "Thông báo");
            }
        }
    }
}
