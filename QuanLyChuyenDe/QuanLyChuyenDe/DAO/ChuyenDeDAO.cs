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
    public class ChuyenDeDAO
    {
        private static ChuyenDeDAO instance;

        public static ChuyenDeDAO Instance
        {
            get {
                if(instance == null)
                    instance = new ChuyenDeDAO();
                return instance; }
    
        }

        private ChuyenDeDAO() { }

        public List<ChuyenDeBUS> select()
        {
            List<ChuyenDeBUS> listCD = new List<ChuyenDeBUS>();
            DataProvider.Instance.Connect();
            string query = "select * from ChuyenDe";
            DataTable data = DataProvider.Instance.Select(CommandType.Text, query);
            DataProvider.Instance.Disconnect();
            foreach (DataRow item in data.Rows)
            {
                string maCD = item["MaCD"].ToString();
                string tenNganh = item["TenNganh"].ToString();
                string tenCD = item["TenCD"].ToString();
                int slSVToiDa = int.Parse(item["SLSVToiDa"].ToString());
                int slNhomToiDa = int.Parse(item["SLNhomToiDa"].ToString());
                DateTime ngayBD = (DateTime)item["NgayBD"];
                DateTime ngayKT = (DateTime)item["NgayKT"];
                string tt = item["TrangThai"].ToString();

                ChuyenDeBUS cd = new ChuyenDeBUS(maCD, tenNganh, tenCD, slSVToiDa, slNhomToiDa, ngayBD, ngayKT, tt);
                listCD.Add(cd);
            }
            return listCD;
        }

        public ChuyenDeBUS selectCD(string macd)
        {
            DataProvider.Instance.Connect();
            string query = "select * from ChuyenDe where MaCD = @macd";
            DataTable data = DataProvider.Instance.Select(CommandType.Text, query,
                                                new SqlParameter { ParameterName = "@macd", Value = macd });
            DataProvider.Instance.Disconnect();

            string tennganh = data.Rows[0]["TenNganh"].ToString();
            string tencd = data.Rows[0]["TenCD"].ToString();
            int slsvtoida = int.Parse(data.Rows[0]["SLSVToiDa"].ToString());
            int slnhomtoida = int.Parse(data.Rows[0]["SLNhomToiDa"].ToString());
            DateTime ngaybd = (DateTime)data.Rows[0]["NgayBD"];
            DateTime ngaykt = (DateTime)data.Rows[0]["NgayKT"];
            string trangthai = data.Rows[0]["TrangThai"].ToString();

            return new ChuyenDeBUS(macd, tennganh, tencd, slsvtoida, slnhomtoida, ngaybd, ngaykt, trangthai);
        }

        public bool update(ChuyenDeBUS cd)
        {
            DataProvider.Instance.Connect();
            string query = "UpdateChuyenDe";
            int result = DataProvider.Instance.ExecuteNonQuery(CommandType.StoredProcedure, query,
                                        new SqlParameter { ParameterName = "@macd", Value = cd.MaCD },
                                        new SqlParameter { ParameterName = "@tennganh", Value = cd.TenNganh },
                                        new SqlParameter { ParameterName = "@tencd", Value = cd.TenCD },
                                        new SqlParameter { ParameterName = "@slsv", Value = cd.SLSVToiDa },
                                        new SqlParameter { ParameterName = "@slnhom", Value = cd.SLNhomToiDa },
                                        new SqlParameter { ParameterName = "@ngaybd", Value = cd.NgayBD },
                                        new SqlParameter { ParameterName = "@ngaykt", Value = cd.NgayKT },
                                        new SqlParameter { ParameterName = "@trangthai", Value = cd.TrangThai });
            DataProvider.Instance.Disconnect();
            return result != 0;
        }

        public string selectMaCDMoi()
        {
            string result = "CD01";
            DataProvider.Instance.Connect();
            string query = "select max(MaCD) from ChuyenDe";
            DataTable data = DataProvider.Instance.Select(CommandType.Text, query);
            DataProvider.Instance.Disconnect();
            if (data != null)
            {
                int count = int.Parse(data.Rows[0][0].ToString().Substring(2, 2));
                count += 1;
                if (count < 10)
                {
                    result = "CD0" + count.ToString();
                }
                else
                {
                    result = "CD" + count.ToString();
                }
            }
            return result;
        }
        
        public bool detele(string macd)
        {
            DataProvider.Instance.Connect();
            string query = "DeleteChuyenDe";
            int result = DataProvider.Instance.ExecuteNonQuery(CommandType.StoredProcedure, query,
                                        new SqlParameter { ParameterName = "@macd", Value = macd });
            DataProvider.Instance.Disconnect();
            return result != 0;
        }
    }
}
