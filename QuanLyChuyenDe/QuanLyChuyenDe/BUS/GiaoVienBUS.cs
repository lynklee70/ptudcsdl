using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyChuyenDe.DAO;
using System.Windows.Forms;
using QuanLyChuyenDe.GUI;

namespace QuanLyChuyenDe.BUS
{
    public class GiaoVienBUS
    {
        public static GiaoVienBUS instance;

        public static GiaoVienBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new GiaoVienBUS();
                return instance;
            }

        }


        string maGV, tenGV;

        public string MaGV
        {
            get { return maGV; }
            set { maGV = value; }
        }

        public string TenGV
        {
            get { return tenGV; }
            set { tenGV = value; }
        }

        int gioiTinh;

        public int GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }

        string sDT;

        public string SDT
        {
            get { return sDT; }
            set { sDT = value; }
        }

        DateTime ngaySinh;

        public DateTime NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }

        public GiaoVienBUS(string maGV, string tenGV, int gioiTinh, string sDT, DateTime ngaySinh)
        {
            this.maGV = maGV;
            this.tenGV = tenGV;
            this.gioiTinh = gioiTinh;
            this.sDT = sDT;
            this.ngaySinh = ngaySinh;
        }

        public void loadForm(string magv, TextBox txtHoTen, RadioButton radNam, RadioButton radNu, DateTimePicker dtpNgaySinh, TextBox txtSDT)
        {
            GiaoVienBUS gv = GiaoVienBUS.Instance.load(magv);
            if (!string.IsNullOrEmpty(gv.MaGV))
            {
                txtHoTen.Text = gv.TenGV;
                txtSDT.Text = gv.SDT;
                dtpNgaySinh.Text = gv.NgaySinh.ToString();
                if (gv.GioiTinh == 1)
                    radNam.Checked = true;
                else
                    radNu.Checked = true;
            }
        }

        public GiaoVienBUS() { }

        public GiaoVienBUS load(string magv)
        {
            return GiaoVienDAO.Instance.load(magv);
        }

        public int update(GiaoVienBUS gv)
        {
            return GiaoVienDAO.Instance.update(gv);
        }

    }
}
