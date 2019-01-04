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
    public partial class frmCapNhatChuyenDe : Form
    {
        public delegate void CloseEvent();
        public event CloseEvent WindowClosed;
        public frmCapNhatChuyenDe()
        {
            InitializeComponent();
        }

        public frmCapNhatChuyenDe(string macd)
        {
            InitializeComponent();
            this.AcceptButton = btnCapNhat;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            loadForm(macd);
        }

        public void loadForm(string macd)
        {
            ChuyenDeBUS.Instance.loadFormCapNhat(macd, this);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if(ChuyenDeBUS.Instance.update(this))
            {
                MessageBox.Show("Cập nhật thành công", "Thông báo");
                this.Close();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại! Tên chuyên đề đã tồn tại", "Thông báo");
            }
        }

        private void frmCapNhatChuyenDe_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Gọi event load lại form frmDanhSachChuyenDe
            WindowClosed();
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

        
    }
}
