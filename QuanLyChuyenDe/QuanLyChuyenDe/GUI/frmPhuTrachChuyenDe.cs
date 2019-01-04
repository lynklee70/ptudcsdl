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
    public partial class frmPhuTrachChuyenDe : Form
    {
        string MaGV = "";
        public frmPhuTrachChuyenDe()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
        }

        public frmPhuTrachChuyenDe(string magv)
        {
            InitializeComponent();
            MaGV = magv;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
        }

        private void frmPhuTrachChuyenDe_Load(object sender, EventArgs e)
        {
            LopHocBUS.Instance.loadFormCapNhat(this);
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            if (LopHocBUS.Instance.insert(MaGV, this) == 1)
            {
                MessageBox.Show("Chọn thành công", "Thông báo");
                this.Close();
            }
            else
            {
                MessageBox.Show("Thêm thất bại! Chuyên đề đang đóng.", "Thông báo");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
