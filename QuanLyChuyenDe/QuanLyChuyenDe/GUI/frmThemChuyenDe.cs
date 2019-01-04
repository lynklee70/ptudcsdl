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
        public delegate void CloseEvent();
        public event CloseEvent WindowClosed;
        public frmThemChuyenDe()
        {
            InitializeComponent();
            this.AcceptButton = btnThem;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
        }

        //Chỉ cho phép nhập số 0-9
        private void txtSLSVToiDa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //Chỉ cho phép nhập số 0-9
        private void txtSLNhomToiDa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void frmThemChuyenDe_Load(object sender, EventArgs e)
        {
            load();
        }

        public void load()
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
            if (!ChuyenDeBUS.Instance.ngayKTValueChange(dtpNgayBD, dtpNgayKT))
            {
                MessageBox.Show("Ngày kết thúc không được nhỏ hơn ngày bắt đầu", "Thông báo");
            }
        }

        private void frmThemChuyenDe_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Gọi event WindowClosed() để load lại formDanhSachChuyenDe
            WindowClosed();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (ChuyenDeBUS.Instance.insert(this))
            {
                MessageBox.Show("Thêm thành công", "Thông báo");
                WindowClosed();
                load();
            }
            else
            {
                MessageBox.Show("Tên chuyên đề đã tồn tại", "Thông báo");
            }
        }
    }
}
