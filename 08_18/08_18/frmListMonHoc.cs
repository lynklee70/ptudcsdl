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

namespace _08_18
{
    public partial class frmListMonHoc : Form
    {
        public frmListMonHoc()
        {
            InitializeComponent();
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            MonHocBUS.Instance.Xem(dataGridView1, comboBox1);
        }
    }
}
