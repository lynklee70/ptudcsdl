using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyChuyenDe.BUS;
using System.Windows.Forms;

namespace QuanLyChuyenDe.DAO
{
    public class GiaoVienDAO
    {
        private static GiaoVienDAO instance;

        public static GiaoVienDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new GiaoVienDAO();
                return instance;
            }

        }

        public GiaoVienDAO() { }

        public GiaoVienBUS load(string magv)
        {
            DataProvider.Instance.Connect();

            GiaoVienBUS gv = new GiaoVienBUS();

            string query = "select * from GiaoVien where MaGV = @magv";

            DataTable data = DataProvider.Instance.Select(CommandType.Text, query, new SqlParameter { ParameterName = "@magv", Value = magv });

            if (!string.IsNullOrEmpty(data.Rows[0][2].ToString()))
            {
                gv.MaGV = magv;
                gv.TenGV = data.Rows[0][1].ToString();
                gv.GioiTinh = int.Parse(data.Rows[0][2].ToString());
                gv.SDT = data.Rows[0][3].ToString();
                gv.NgaySinh = (DateTime)data.Rows[0][4];
            }
            DataProvider.Instance.Disconnect();

            return gv;
        }

        public int update(GiaoVienBUS gv)
        {
            DataProvider.Instance.Connect();

            string query = "UpdateGV";

            int rs = DataProvider.Instance.ExecuteNonQuery(CommandType.StoredProcedure, query,
                new SqlParameter { ParameterName = "@magv", Value = gv.MaGV },
                new SqlParameter { ParameterName = "@hoten", Value = gv.TenGV },
                new SqlParameter { ParameterName = "@gioitinh", Value = gv.GioiTinh },
                new SqlParameter { ParameterName = "@ngaysinh", Value = gv.NgaySinh },
                new SqlParameter { ParameterName = "@sodienthoai", Value = gv.SDT }
                );
            DataProvider.Instance.Disconnect();
            return rs;
        }
    }
}
