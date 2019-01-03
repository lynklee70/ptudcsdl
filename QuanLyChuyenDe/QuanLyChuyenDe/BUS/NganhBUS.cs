using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChuyenDe.BUS
{
    public class NganhBUS
    {
        int sLSVTungHoc, sLChuyenDe;

        string maNganh;

        public string MaNganh
        {
            get { return maNganh; }
            set { maNganh = value; }
        }
        

        public int SLSVTungHoc
        {
            get { return sLSVTungHoc; }
            set { sLSVTungHoc = value; }
        }

        public int SLChuyenDe
        {
            get { return sLChuyenDe; }
            set { sLChuyenDe = value; }
        }
        string tenNganh;

        public string TenNganh
        {
            get { return tenNganh; }
            set { tenNganh = value; }
        }

        public NganhBUS(string maNganh, string tenNganh, int sLSVTungHoc, int sLChuyenDe)
        {
            this.MaNganh = maNganh;
            this.TenNganh = tenNganh;
            this.SLChuyenDe = sLChuyenDe;
            this.SLSVTungHoc = sLSVTungHoc;
        }
    }
}
