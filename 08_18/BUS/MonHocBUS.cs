using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
namespace BUS
{
    public class MonHocBUS
    {
        private static MonHocBUS instance;

        public static MonHocBUS Instance
        {
            get {
                if(instance == null)
                    instance = new MonHocBUS();
                return instance; }
    
        }

        private MonHocBUS() { }

        public void Xem(DataGridView dgv, ComboBox cb)
        {
            var list = MonHocDAO.Instance.Xem();
            foreach (var item in list)
            {
                cb.Items.Add(item.MaCD);
            }
            dgv.DataSource = list;
        }
    }
}
