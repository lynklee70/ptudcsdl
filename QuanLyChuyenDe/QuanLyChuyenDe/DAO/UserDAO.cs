using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyChuyenDe.BUS;

namespace QuanLyChuyenDe.DAO
{
    public class UserDAO
    {
        private static UserDAO instance;

        public static UserDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new UserDAO();
                return instance;
            }

        }
        private UserDAO() { }

        public List<User_BUS> Xem(string k, string type)
        {

            List<User_BUS> users = new List<User_BUS>();
            string query = "select * from SinhVien_Hoc_Lop";
            if (type == "ms")
            {
                query = "select * from SinhVien_Hoc_Lop where MaSV='" + k + "'";
            }
            else if (type == "mcd")
            {
                query = "select * from SinhVien_Hoc_Lop where MaCD='" + k + "'";
            }
            else if (type == "ml")
            {
                query = "select * from SinhVien_Hoc_Lop where MaLop='" + k + "'";
            }
            else if (type == "tc")
            {
                query = "select * from SinhVien_Hoc_Lop";
            }
           
            DataTable data = DataProvider.Instance.Select(CommandType.Text, query);
            foreach (DataRow item in data.Rows)
            {
                string masv = item["MaSV"].ToString();
                string macd = item["MaCD"].ToString();
                string malop = item["MaLop"].ToString();
                string diem = item["Diem"].ToString();
                User_BUS newUser = new User_BUS(masv, malop, macd, diem);
                users.Add(newUser);
            }
            return users;
            
        }

        public List<UserBUS> TraCuu(string k, string type)
        {
            //k biet :)) :v  type ko  = hk
            List<UserBUS> users = new List<UserBUS>();
            string query = "select * from SV_DANGKY_CD";
            if (type == "ms")
            {
                query = "select * from SV_DANGKY_CD where MaSV='" + k +"'";
            }
            else if (type == "mcd")
            {
                query = "select * from SV_DANGKY_CD where MaCD='" + k + "'";
            }           
            else if (type == "mn")
            {
                query = "select * from SV_DANGKY_CD where MaNhom='" + k +"'";
            }
            else if (type == "hk")
            {
                query = "select * from SV_DANGKY_CD where HocKy=" +k;
            }
            else if (type == "nh")
            {
                query = "select * from SV_DANGKY_CD where NamHoc=" + k;
            }
            else if (type == "tc")
            {
                query = "select * from SV_DANGKY_CD";
            }

            DataTable data = DataProvider.Instance.Select(CommandType.Text, query);
            foreach (DataRow item in data.Rows)
            {
                string masv = item["MaSV"].ToString();
                string macd = item["MaCD"].ToString();
                string manhom = item["MaNhom"].ToString();
                string hocky = item["HocKy"].ToString();
                string namhoc = item["NamHoc"].ToString();
                UserBUS newUser = new UserBUS(masv, macd, manhom, hocky, namhoc);
                users.Add(newUser);

            }
            return users;
        }
    }
}
