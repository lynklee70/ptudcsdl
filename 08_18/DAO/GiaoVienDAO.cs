using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class GiaoVienDAO
    {
        private static GiaoVienDAO instance;

        public static GiaoVienDAO Instance
        {
            get {
                if(instance == null)
                    instance = new GiaoVienDAO();
                return instance; }
    
        }

        private GiaoVienDAO() { }

        public GiaoVien load(string magv)
        {
            DataProvider.Instance.Connect();

            GiaoVien gv = new GiaoVien();

            string query = "select * from GiaoVien1 where MaGV = @magv";

            DataTable data = DataProvider.Instance.Select(CommandType.Text, query, new SqlParameter { ParameterName = "@magv", Value = magv });

            if(!string.IsNullOrEmpty(data.Rows[0][2].ToString()))
            {
                gv.MaGV = magv;
                gv.HoTen = data.Rows[0][1].ToString();
                gv.GioiTinh = int.Parse(data.Rows[0][2].ToString());
                gv.SoDienThoai = data.Rows[0][3].ToString();
                gv.NgaySinh = (DateTime)data.Rows[0][4];
            }
            DataProvider.Instance.Disconnect();

            return gv;
        }

        public int update(GiaoVien gv)
        {
            DataProvider.Instance.Connect();

            string query = "UpdateGV";

            int rs = DataProvider.Instance.ExecuteNonQuery(CommandType.StoredProcedure, query,
                new SqlParameter { ParameterName = "@magv", Value = gv.MaGV },
                new SqlParameter { ParameterName = "@hoten", Value = gv.HoTen },
                new SqlParameter { ParameterName = "@gioitinh", Value = gv.GioiTinh },
                new SqlParameter { ParameterName = "@ngaysinh", Value = gv.NgaySinh },
                new SqlParameter { ParameterName = "@sodienthoai", Value = gv.SoDienThoai }
                );
            DataProvider.Instance.Disconnect();
            return rs;
        }
    }
}
