using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using DTO;

namespace BUS
{
    public class GiaoVienBUS
    {
        private static GiaoVienBUS instance;

        public static GiaoVienBUS Instance
        {
            get {
                if(instance == null)
                    instance = new GiaoVienBUS();
                return instance; }
    
        }

        private GiaoVienBUS() { }

        public GiaoVien load(string magv)
        {
            return GiaoVienDAO.Instance.load(magv);
        }

        public int update(GiaoVien gv)
        {
            return GiaoVienDAO.Instance.update(gv);
        }
    }
}
