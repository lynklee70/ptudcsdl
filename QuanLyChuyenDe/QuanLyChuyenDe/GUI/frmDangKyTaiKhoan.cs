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
    public partial class frmDangKyTaiKhoan : Form
    {
        public frmDangKyTaiKhoan()
        {
            InitializeComponent();
            this.AcceptButton = btn_DangKy;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
        }

        private void loadForm()
        {
            AccountBUS.Instance.Load(txtUsername, cbbType.SelectedIndex);
        }

        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            int type = cbbType.SelectedIndex;
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Không được để trống tài khoản và mật khẩu!", "Thông báo");
            }
            else
            {
                bool rs = AccountBUS.Instance.insert(username, password, type);
                if (!rs)
                {
                    MessageBox.Show("Đã tồn tại tên tài khoản!", "Thông báo");
                }
                else
                {
                    loadForm();
                    MessageBox.Show("Đăng kí thành công!", "Thông báo");
                }
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDangKyTaiKhoan_Load(object sender, EventArgs e)
        {
            //Mặc định là sinh viên
            cbbType.SelectedIndex = 1;
            loadForm();
        }

        private void cbbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadForm();
        }
    }
}
