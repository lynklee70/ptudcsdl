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
            GiaoVienBUS.Instance.loadForm(MaGV, txtHoTen, radNam, radNu, dtpNgaySinh, txtSDT);
        }


        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            string HoTen = txtHoTen.Text;
            string SoDienThoai = txtSDT.Text;
            int GioiTinh = 1;
            if (radNu.Checked == true)
                GioiTinh = 0;
            DateTime NgaySinh = dtpNgaySinh.Value;
            GiaoVienBUS gv = new GiaoVienBUS(MaGV, HoTen, GioiTinh, SoDienThoai, NgaySinh);
            int rs = GiaoVienBUS.Instance.update(gv);
            if (rs != 0)
            {
                MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo");
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
