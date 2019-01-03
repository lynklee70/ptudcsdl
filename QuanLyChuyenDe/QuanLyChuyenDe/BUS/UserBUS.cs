using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyChuyenDe.DAO;
using System.Windows.Forms;

namespace QuanLyChuyenDe.BUS
{
    public class UserBUS
    {
        private static UserBUS instance;       
        public static UserBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new UserBUS();
                return instance;
            }

        }
         
        private UserBUS() { }
        
        private string MaSV, MaCD, MaNhom, HocKy, NamHoc;


            public string MASV
            {
                get { return MaSV; }
                set { MaSV = value; }
            }

            public string MACD
            {
                get { return MaCD; }
                set { MaCD = value; }
            }

            public string MANHOM
            {
                get { return MaNhom; }
                set { MaNhom = value; }
            }          

            public string HOCKY
            {
                get { return HocKy; }
                set { HocKy = value; }
            }

            public string NAMHOC
            {
                get { return NamHoc; }
                set { NamHoc = value; }
            }

            public UserBUS(string masv, string macd, string manhom, string hocky, string namhoc)
            {
                this.MaSV = masv;
                this.MaCD = macd;
                this.MaNhom = manhom;
                this.HocKy = hocky;
                this.NamHoc = namhoc;
            }
                 
        public void TraCuu(DataGridView data,string temp,string type)
        {
            data.DataSource = UserDAO.Instance.TraCuu(temp,type);
        }
    }

    public class User_BUS
    {
        private static User_BUS instance;
        public static User_BUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new User_BUS();
                return instance;
            }

        }

        private User_BUS() { }

        private string MaSV, MaLop, MaCD, Diem;


        public string MASV
        {
            get { return MaSV; }
            set { MaSV = value; }
        }
        public string MALOP
        {
            get { return MaLop; }
            set { MaLop = value; }
        }
        public string MACD
        {
            get { return MaCD; }
            set { MaCD = value; }
        }
        public string DIEM
        {
            get { return Diem; }
            set { Diem = value; }
        }
       
      
        public User_BUS(string masv,string malop, string macd,string diem)
        {
            this.MaSV = masv;
            this.MaCD = macd;
            this.MaLop = malop;
            this.Diem = diem;
        }

        public void Xem(DataGridView data,string temp,string type)
        {
            data.DataSource = UserDAO.Instance.Xem(temp,type);
        }      
    }
}
