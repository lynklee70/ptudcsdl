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
        }

        private void frmPhuTrachChuyenDe_Load(object sender, EventArgs e)
        {
            LopHocBUS.Instance.loadFormCapNhat(this);
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            LopHocBUS.Instance.insert(MaGV, this);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
