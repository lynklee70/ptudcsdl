using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace _08_18
{
    public partial class frmCapNhatThongTin : Form
    {
        private string MaGV = "";
        public frmCapNhatThongTin()
        {
            InitializeComponent();
        }

        public frmCapNhatThongTin(string magv)
        {
            InitializeComponent();
            MaGV = magv;
            loadForm(MaGV, txtHoTen, radNam, radNu, dtpNgaySinh, txtSDT);
        }

        private void loadForm(string magv, TextBox txtHoTen, RadioButton radNam, RadioButton radNu, DateTimePicker ngaySinh, TextBox SDT)
        {
            GiaoVien gv = GiaoVienBUS.Instance.load(magv);
            if (!string.IsNullOrEmpty(gv.MaGV))
            {
                txtHoTen.Text = gv.HoTen;
                txtSDT.Text = gv.SoDienThoai;
                dtpNgaySinh.Text = gv.NgaySinh.ToString();
                if (gv.GioiTinh == 1)
                    radNam.Checked = true;
                else
                    radNu.Checked = true;
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            string HoTen = txtHoTen.Text;
            string SoDienThoai = txtSDT.Text;
            int GioiTinh = 1;
            if (radNu.Checked == true)
                GioiTinh = 0;
            DateTime NgaySinh = dtpNgaySinh.Value;
            GiaoVien gv = new GiaoVien(HoTen, SoDienThoai, MaGV, GioiTinh, NgaySinh);
            int rs = GiaoVienBUS.Instance.update(gv);
            if(rs != 0)
            {
                MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo");
            }
        }

        
    }
}
