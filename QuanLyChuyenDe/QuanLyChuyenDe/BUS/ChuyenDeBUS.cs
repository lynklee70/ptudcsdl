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
    public class ChuyenDeBUS
    {
        private static ChuyenDeBUS instance;

        public static ChuyenDeBUS Instance
        {
            get {
                if(instance == null)
                    instance = new ChuyenDeBUS();
                return instance; }
    
        }

        private ChuyenDeBUS() { }

        private string maCD;

        public string MaCD
        {
            get { return maCD; }
            set { maCD = value; }
        }


        private string tenNganh;

        public string TenNganh
        {
            get { return tenNganh; }
            set { tenNganh = value; }
        }

        private string tenCD;

        public string TenCD
        {
            get { return tenCD; }
            set { tenCD = value; }
        }

        
        private int sLSVToiDa;

        public int SLSVToiDa
        {
            get { return sLSVToiDa; }
            set { sLSVToiDa = value; }
        }
        private int sLNhomToiDa;

        public int SLNhomToiDa
        {
            get { return sLNhomToiDa; }
            set { sLNhomToiDa = value; }
        }
        private DateTime ngayBD;

        public DateTime NgayBD
        {
            get { return ngayBD; }
            set { ngayBD = value; }
        }
        private DateTime ngayKT;

        public DateTime NgayKT
        {
            get { return ngayKT; }
            set { ngayKT = value; }
        }
        private string trangThai;

        public string TrangThai
        {
            get { return trangThai; }
            set { trangThai = value; }
        }

        public ChuyenDeBUS(string maCD, string tenNganh, string tenCD, int slsvToiDa, int slNhomToiDa, DateTime ngayBD, DateTime ngayKT, string TT)
        {
            this.MaCD = maCD;
            this.TenNganh = tenNganh;
            this.TenCD = tenCD;
            this.SLSVToiDa = slsvToiDa;
            this.NgayBD = ngayBD;
            this.NgayKT = ngayKT;
            this.TrangThai = TT;
        }

        public void ngayBDValueChange(DateTimePicker ngayBD, DateTimePicker ngayKT)
        {
            ngayKT.Value = ngayBD.Value.AddDays(98);
        }

        public void ngayKTValueChange(DateTimePicker ngayBD, DateTimePicker ngayKT)
        {
            if (ngayKT.Value.Date < ngayBD.Value.Date)
            { 
                MessageBox.Show("Ngày kết thúc không được nhỏ hơn ngày bắt đầu", "Thông báo");
                ngayKT.Value = ngayBD.Value.AddDays(98);
            }
        }

        public void loadFormDanhSach(DataGridView dgv)
        {
            dgv.DataSource = ChuyenDeDAO.Instance.select();
        }

        public void loadFormThem(frmThemChuyenDe frm)
        {
            TextBox txtMaCD = frm.Controls.Find("txtMaCD", true).FirstOrDefault() as TextBox;
            ComboBox cbTenNganh = frm.Controls.Find("cbTenNganh", true).FirstOrDefault() as ComboBox;
            TextBox txtTenCD = frm.Controls.Find("txtTenCD", true).FirstOrDefault() as TextBox;
            TextBox txtSLSVToiDa = frm.Controls.Find("txtSLSVToiDa", true).FirstOrDefault() as TextBox;
            TextBox txtSLNhomToiDa = frm.Controls.Find("txtSLNhomToiDa", true).FirstOrDefault() as TextBox;
            ComboBox cbTrangThai = frm.Controls.Find("cbTrangThai", true).FirstOrDefault() as ComboBox;
            DateTimePicker dtpNgayBD = frm.Controls.Find("dtpNgayBD", true).FirstOrDefault() as DateTimePicker;
            DateTimePicker dtpNgayKT = frm.Controls.Find("dtpNgayKT", true).FirstOrDefault() as DateTimePicker;

            txtMaCD.Text = ChuyenDeDAO.Instance.selectMaCDMoi();

            List<NganhBUS> listNganh = NganhDAO.Instance.selectAll();
            foreach(var nganh in listNganh)
            {
                cbTenNganh.Items.Add(nganh.TenNganh);
            }
            cbTenNganh.SelectedIndex = 0;

            cbTrangThai.Items.Add("Mở");
            cbTrangThai.Items.Add("Đóng");
            cbTrangThai.SelectedIndex = 0;

            dtpNgayBD.Value = DateTime.Now;
            dtpNgayKT.Value = DateTime.Now.AddDays(98);
        }

        public void loadFormCapNhat(string macd, frmCapNhatChuyenDe frm)
        {
            TextBox txtMaCD = frm.Controls.Find("txtMaCD", true).FirstOrDefault() as TextBox;
            ComboBox cbTenNganh = frm.Controls.Find("cbTenNganh", true).FirstOrDefault() as ComboBox;
            TextBox txtTenCD = frm.Controls.Find("txtTenCD", true).FirstOrDefault() as TextBox;
            TextBox txtSLSVToiDa = frm.Controls.Find("txtSLSVToiDa", true).FirstOrDefault() as TextBox;
            TextBox txtSLNhomToiDa = frm.Controls.Find("txtSLNhomToiDa", true).FirstOrDefault() as TextBox;
            ComboBox cbTrangThai = frm.Controls.Find("cbTrangThai", true).FirstOrDefault() as ComboBox;
            DateTimePicker dtpNgayBD = frm.Controls.Find("dtpNgayBD", true).FirstOrDefault() as DateTimePicker;
            DateTimePicker dtpNgayKT = frm.Controls.Find("dtpNgayKT", true).FirstOrDefault() as DateTimePicker;

            ChuyenDeBUS cd = ChuyenDeDAO.Instance.selectCD(macd);

            List<NganhBUS> listNganh = NganhDAO.Instance.selectAll();
            foreach (var nganh in listNganh)
            {
                cbTenNganh.Items.Add(nganh.TenNganh);
            }

            txtMaCD.Text = cd.MaCD;
            cbTenNganh.Text = cd.TenNganh;
            txtTenCD.Text = cd.TenCD;
            txtSLSVToiDa.Text = cd.SLSVToiDa.ToString();
            txtSLNhomToiDa.Text = cd.SLNhomToiDa.ToString();
            cbTrangThai.Text = cd.TrangThai;
            dtpNgayBD.Value = cd.NgayBD;
            dtpNgayKT.Value = cd.NgayKT;
            
        }

        public bool delete(DataGridView dgv)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                string macd = dgv.SelectedCells[0].OwningRow.Cells["MaCD"].Value.ToString();
                return ChuyenDeDAO.Instance.detele(macd);
            }
            else
                return false;
        }

        public bool update(frmCapNhatChuyenDe frm)
        {
            TextBox txtMaCD = frm.Controls.Find("txtMaCD", true).FirstOrDefault() as TextBox;
            ComboBox cbTenNganh = frm.Controls.Find("cbTenNganh", true).FirstOrDefault() as ComboBox;
            TextBox txtTenCD = frm.Controls.Find("txtTenCD", true).FirstOrDefault() as TextBox;
            TextBox txtSLSVToiDa = frm.Controls.Find("txtSLSVToiDa", true).FirstOrDefault() as TextBox;
            TextBox txtSLNhomToiDa = frm.Controls.Find("txtSLNhomToiDa", true).FirstOrDefault() as TextBox;
            ComboBox cbTrangThai = frm.Controls.Find("cbTrangThai", true).FirstOrDefault() as ComboBox;
            DateTimePicker dtpNgayBD = frm.Controls.Find("dtpNgayBD", true).FirstOrDefault() as DateTimePicker;
            DateTimePicker dtpNgayKT = frm.Controls.Find("dtpNgayKT", true).FirstOrDefault() as DateTimePicker;

            string macd = txtMaCD.Text;
            string tennganh = cbTenNganh.Text;
            string tencd = txtTenCD.Text;
            int slsv = int.Parse(txtSLSVToiDa.Text);
            int slnhom = int.Parse(txtSLNhomToiDa.Text);
            string trangthai = cbTrangThai.Text;
            DateTime ngaybd = dtpNgayBD.Value;
            DateTime ngaykt = dtpNgayKT.Value;

            ChuyenDeBUS cd = new ChuyenDeBUS(macd, tennganh, tencd, slsv, slnhom, ngaybd, ngaykt, trangthai);

            return ChuyenDeDAO.Instance.update(cd);
        }

        public int insert(frmThemChuyenDe frm)
        {
            TextBox txtMaCD = frm.Controls.Find("txtMaCD", true).FirstOrDefault() as TextBox;
            ComboBox cbTenNganh = frm.Controls.Find("cbTenNganh", true).FirstOrDefault() as ComboBox;
            TextBox txtTenCD = frm.Controls.Find("txtTenCD", true).FirstOrDefault() as TextBox;
            TextBox txtSLSVToiDa = frm.Controls.Find("txtSLSVToiDa", true).FirstOrDefault() as TextBox;
            TextBox txtSLNhomToiDa = frm.Controls.Find("txtSLNhomToiDa", true).FirstOrDefault() as TextBox;
            ComboBox cbTrangThai = frm.Controls.Find("cbTrangThai", true).FirstOrDefault() as ComboBox;
            DateTimePicker dtpNgayBD = frm.Controls.Find("dtpNgayBD", true).FirstOrDefault() as DateTimePicker;
            DateTimePicker dtpNgayKT = frm.Controls.Find("dtpNgayKT", true).FirstOrDefault() as DateTimePicker;

            string macd = txtMaCD.Text;
            string tennganh = cbTenNganh.Text;
            string tencd = txtTenCD.Text;
            int slsv = 0;
            int.TryParse(txtSLSVToiDa.Text, out slsv);
            int slnhom = 0;
            int.TryParse(txtSLNhomToiDa.Text, out slsv);
            string trangthai = cbTrangThai.Text;
            DateTime ngaybd = dtpNgayBD.Value.Date;
            DateTime ngaykt = dtpNgayKT.Value.Date;

            if(ChuyenDeDAO.Instance.checkTen(tencd))
            {
                return 2;
            }

            ChuyenDeBUS cd = new ChuyenDeBUS(macd, tennganh, tencd, slsv, slnhom, ngaybd, ngaykt, trangthai);

            return ChuyenDeDAO.Instance.insert(cd) == true ? 1 : 0;
        }
    }
}
