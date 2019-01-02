using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
namespace DAO
{
    public class MonHocDAO
    {
        private static MonHocDAO instance;

        public static MonHocDAO Instance
        {
            get {
                if(instance == null)
                    instance = new MonHocDAO();
                return instance; }
    
        }

        private MonHocDAO() { }

        public List<MonHocDTO> Xem()
        {
            List<MonHocDTO> lstMH = new List<MonHocDTO>();
            DataProvider.Instance.Connect();
            string query = "select * from ChuyenDe";

            DataTable data = DataProvider.Instance.Select(CommandType.Text, query);
            DataProvider.Instance.Disconnect();
            foreach (DataRow item in data.Rows)
            {
                int maCD = int.Parse(item["MaCD"].ToString());
                int maNganh = int.Parse(item["MaNganh"].ToString());
                string tenCD = item["TenCD"].ToString();
                int slSVToiDa = int.Parse(item["SLSVToiDa"].ToString());
                int slNhomToiDa = int.Parse(item["SLNhomToiDa"].ToString());
                DateTime ngayBD = (DateTime)item["NgayBD"];
                DateTime ngayKT = (DateTime)item["NgayKT"];
                int tt = int.Parse(item["TrangThai"].ToString());

                MonHocDTO mh = new MonHocDTO(maCD, maNganh, tenCD, slSVToiDa, slNhomToiDa, ngayBD, ngayKT, tt);
                lstMH.Add(mh);
            }
            return lstMH;
        }
    }
}
