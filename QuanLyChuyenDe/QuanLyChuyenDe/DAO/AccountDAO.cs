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
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new AccountDAO();
                return instance;
            }
        }

        private AccountDAO() { }

        private String getMD5(String password)
        {
            String str = "";

            Byte[] buffer = System.Text.Encoding.UTF8.GetBytes(password);

            System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();

            buffer = md5.ComputeHash(buffer);

            foreach (Byte b in buffer)
            {
                str += b.ToString("X2");
            }
            return str;
        }

        public bool insert(AccountBUS acc)
        {
            DataProvider.Instance.Connect();
            string query = "InsertTK";
            int insert = DataProvider.Instance.ExecuteNonQuery(CommandType.StoredProcedure, query,
                 new SqlParameter { ParameterName = "@user", Value = acc.Username },
                 new SqlParameter { ParameterName = "@pw", Value = getMD5(acc.Password) },
                 new SqlParameter { ParameterName = "@type", Value = acc.Type });
            DataProvider.Instance.Disconnect();
            if (insert > 0)
            {
                return true;
            }
            return false;
        }

        public string GetUsername(int type)
        {
            string rs = "SV";
            if (type == 0)
            {
                rs = "GV";
            }
            string query = "select max(Username) from TaiKhoan where type = " + type;
            DataProvider.Instance.Connect();
            DataTable data = DataProvider.Instance.Select(CommandType.Text, query);
            string username = data.Rows[0][0].ToString();
            if (username != "")
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

        public int select(string username, string password)
        {
            DataProvider.Instance.Connect();

            string query = "select * from TaiKhoan where UserName = @username and MatKhau = @password";

            DataTable data = DataProvider.Instance.Select(CommandType.Text, query,
                new SqlParameter { ParameterName = "@username", Value = username },
                 new SqlParameter { ParameterName = "@password", Value = getMD5(password) }
                );

            DataProvider.Instance.Disconnect();

            if (data.Rows.Count > 0)
                return int.Parse(data.Rows[0][2].ToString());
            return -1;
        }
    }
}
