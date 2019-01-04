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
    public class LopHocBUS
    {
        private static LopHocBUS instance;

        public static LopHocBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new LopHocBUS();
                return instance;
            }

        }
        string maLop, maCD, tenLop, gvPhuTrach;

        public LopHocBUS() { }

        public string MaLop
        {
            get { return maLop; }
            set { maLop = value; }
        }

        public string MaCD
        {
            get { return maCD; }
            set { maCD = value; }
        }

        public string TenLop
        {
            get { return tenLop; }
            set { tenLop = value; }
        }

        public string GvPhuTrach
        {
            get { return gvPhuTrach; }
            set { gvPhuTrach = value; }
        }

        public LopHocBUS(string maLop, string maCD, string gvPhuTrach, string tenLop)
        {
            this.MaLop = maLop;
            this.MaCD = maCD;
            this.TenLop = tenLop;
            this.GvPhuTrach = gvPhuTrach;
        }

        public void loadFormCapNhat(frmPhuTrachChuyenDe frm)
        {
            ComboBox cbbChuyenDe = frm.Controls.Find("cbbChuyenDe", true).FirstOrDefault() as ComboBox;
            List<ChuyenDeBUS> list = ChuyenDeDAO.Instance.select();
            foreach (var item in list)
            {
                cbbChuyenDe.Items.Add(item.TenCD);
            }   
            cbbChuyenDe.SelectedIndex = 0;
        }

        public int insert(string magv, frmPhuTrachChuyenDe frm)
        {
            TextBox txtTenLop = frm.Controls.Find("txtTenLop", true).FirstOrDefault() as TextBox;
            ComboBox cbbChuyenDe = frm.Controls.Find("cbbChuyenDe", true).FirstOrDefault() as ComboBox;
            string chuyende = cbbChuyenDe.SelectedItem.ToString();

            string malop = LopHocDAO.Instance.GetMaLop();
            string macd = ChuyenDeDAO.Instance.getMaCD(chuyende);
            string tenlop = txtTenLop.Text;
            string MaGV = magv;

            if (!(ChuyenDeDAO.Instance.checkTrangThai(macd)))
            {
                return 0;
            }

            LopHocBUS lh = new LopHocBUS(malop, macd, magv, tenlop);
            LopHocDAO.Instance.insert(lh);

            return 1;
        }
    }
}
