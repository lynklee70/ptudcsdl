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
        public CloseEvent WindowClosed;
        public frmCapNhatChuyenDe()
        {
            InitializeComponent();
        }

        public frmCapNhatChuyenDe(string macd)
        {
            InitializeComponent();
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
                MessageBox.Show("Cập nhật thất bại", "Thông báo");
            }
        }

        private void frmCapNhatChuyenDe_FormClosed(object sender, FormClosedEventArgs e)
        {
            WindowClosed();
        }
    }
}
