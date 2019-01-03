using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyChuyenDe.BUS;

namespace QuanLyChuyenDe.DAO
{
    public class NganhDAO
    {
        private static NganhDAO instance;

        public static NganhDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new NganhDAO();
                return instance;
            }
        }

        private NganhDAO() { }

        public List<NganhBUS> selectAll()
        {
            List<NganhBUS> listNganh = new List<NganhBUS>();

            DataProvider.Instance.Connect();
            string query = "select * from Nganh";
            DataTable data = DataProvider.Instance.Select(CommandType.Text, query);
            DataProvider.Instance.Disconnect();

            foreach (DataRow item in data.Rows)
            {
                string maNganh = item["MaNganh"].ToString();
                string tenNganh = item["TenNganh"].ToString();
                int slSVTungHoc = int.Parse(item["SLSVTungHoc"].ToString());
                int slChuyenDe = int.Parse(item["SLChuyenDe"].ToString());

                NganhBUS n = new NganhBUS(maNganh, tenNganh, slSVTungHoc, slChuyenDe);
                listNganh.Add(n);
            }
            return listNganh;
        }
    }
}
