﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace _08_18
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Không được để trống tài khoản và mật khẩu!", "Thông báo");
            }
            else
            {
                int rs = AccountBUS.Instance.select(username, password);
                if (rs == -1)
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Thông báo");
                }
                else if (rs == 0)
                {
                    frmMainGiaoVu frm = new frmMainGiaoVu();
                    frm.ShowDialog();
                }
                else if (rs == 1)
                {
                    frmMainGiaoVien frm = new frmMainGiaoVien(username);
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Show form sinh viên");
                }
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
