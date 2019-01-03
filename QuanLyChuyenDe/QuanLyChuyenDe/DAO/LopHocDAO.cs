using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyChuyenDe.BUS;

namespace QuanLyChuyenDe.DAO
{
    public class LopHocDAO
    {
        private static LopHocDAO instance;

        public static LopHocDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new LopHocDAO();
                return instance;
            }

        }

        public LopHocDAO() { }

        public string GetMaLop()
        {
            string rs = "LH";
            string query = "select max(MaLop) from LOPHOC";
            DataProvider.Instance.Connect();
            DataTable data = DataProvider.Instance.Select(CommandType.Text, query);
            string malop = data.Rows[0][0].ToString();
            if (malop != "")
            {
                string tmp = data.Rows[0][0].ToString();
                int num = int.Parse(tmp.Substring(2, 6));
                num += 1;
                tmp = num.ToString();
                while (tmp.Length <= 5)
                {
                    tmp = "0" + tmp;
                }
                rs += tmp;
            }
            else
            {
                rs += "000001";
            }
            DataProvider.Instance.Disconnect();
            return rs;
        }

        public int insert(LopHocBUS lh)
        {
            DataProvider.Instance.Connect();
            string query = "InsertLH";
            int rs = DataProvider.Instance.ExecuteNonQuery(CommandType.StoredProcedure, query,
                                        new SqlParameter { ParameterName = "@malop", Value = lh.MaLop },
                                        new SqlParameter { ParameterName = "@macd", Value = lh.MaCD },
                                        new SqlParameter { ParameterName = "@tenlop", Value = lh.TenLop },
                                        new SqlParameter { ParameterName = "@gvpt", Value = lh.GvPhuTrach });
            DataProvider.Instance.Disconnect();
            return rs;
        }


    }
}
