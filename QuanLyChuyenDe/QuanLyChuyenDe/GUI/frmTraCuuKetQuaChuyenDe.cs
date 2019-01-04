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
    public partial class frmTraCuuKetQuaChuyenDe : Form
    {
        public string ms,ms2;
        public frmTraCuuKetQuaChuyenDe()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            if (cbbTim_Kiem.Text == "" || string.IsNullOrEmpty(cbbTim_Kiem.Text))
            {
                MessageBox.Show("Lựa chọn kiểu tìm kiếm !");
            }
            else
            {
                if (string.IsNullOrEmpty(txtTim_Kiem.Text) && _TimKiemTheo() != "tc")
                {
                    MessageBox.Show("Chưa nhập thông tin !");
                }
                else
                {
                    ms2=txtTim_Kiem.Text;
                    User_BUS.Instance.Xem(dgvChuyenDe,ms2,_TimKiemTheo());                 
                    dgvChuyenDe.Refresh();
                }
            }
           
        }
        public string _TimKiemTheo()
        {
            string kq = "";
            if (string.IsNullOrEmpty(cbbTim_Kiem.Text))
            {
                kq = "";
            }
            if (cbbTim_Kiem.Text == "Mã Sinh Viên")
            {
                kq = "ms";
            }
            if (cbbTim_Kiem.Text == "Mã Lớp")
            {
                kq = "ml";
            }
            if (cbbTim_Kiem.Text == "Mã Chuyên Đề")
            {
                kq = "mcd";
            }
          
            if (cbbTim_Kiem.Text == "Tất Cả")
            {
                kq = "tc";
            }
            return kq;
        }

        public string TimKiemTheo()
        {
            string kq = "";
            if (string.IsNullOrEmpty(cbbtimkiem.Text))
            {
                kq = "";
            }
            if (cbbtimkiem.Text == "MSSV")
            {
                kq = "ms";
            }
            if (cbbtimkiem.Text == "Mã Chuyên Đề")
            {
                kq = "mcd";
            }
            if (cbbtimkiem.Text == "Mã Nhóm")
            {
                kq = "mn";
            }          
            if (cbbtimkiem.Text == "Học Kỳ")
            {
                kq = "hk";
            }
            if (cbbtimkiem.Text == "Năm Học")
            {
                kq = "nh";
            }
            if (cbbtimkiem.Text == "Tất Cả")
            {
                kq = "tc";
            }
            return kq;
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            if (cbbtimkiem.Text == "" || string.IsNullOrEmpty(cbbtimkiem.Text))
            {
                MessageBox.Show("Lựa chọn kiểu tìm kiếm !");
            }
            else
            {
                if (string.IsNullOrEmpty(txtMssv.Text) && TimKiemTheo() != "tc")
                {
                    MessageBox.Show("Chưa nhập thông tin !");
                }
                else
                {
                    ms = txtMssv.Text;
                    UserBUS.Instance.TraCuu(dgvTraCuu, ms, TimKiemTheo());
                    dgvTraCuu.Refresh();
                }
            }
        }

        private void cbbtimkiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMssv.Text = ""; 
        }

        private void cbbTim_Kiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTim_Kiem.Text = "";
        }
    }
}
