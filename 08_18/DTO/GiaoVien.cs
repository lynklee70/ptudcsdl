using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class GiaoVien
    {
        string maGV, hoTen, soDienThoai;

        public string SoDienThoai
        {
            get { return soDienThoai; }
            set { soDienThoai = value; }
        }

        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }

        public string MaGV
        {
            get { return maGV; }
            set { maGV = value; }
        }
        int gioiTinh;

        public int GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }
        DateTime ngaySinh;

        public DateTime NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }

        public GiaoVien(string hoten, string sodienthoai, string magv, int gioitinh, DateTime ngaysinh)
        {
            HoTen = hoten;
            SoDienThoai = sodienthoai;
            MaGV = magv;
            GioiTinh = gioitinh;
            NgaySinh = ngaysinh;
        }

        public GiaoVien(){}

    }
}
