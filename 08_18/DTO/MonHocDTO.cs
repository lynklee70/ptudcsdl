using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MonHocDTO
    {
        private int maCD;

        public int MaCD
        {
            get { return maCD; }
            set { maCD = value; }
        }
        private int maNganh;

        public int MaNganh
        {
            get { return maNganh; }
            set { maNganh = value; }
        }
        private string tenCD;

        public string TenCD
        {
            get { return tenCD; }
            set { tenCD = value; }
        }

        
        private int sLSVToiDa;

        public int SLSVToiDa
        {
            get { return sLSVToiDa; }
            set { sLSVToiDa = value; }
        }
        private int sLNhomToiDa;

        public int SLNhomToiDa
        {
            get { return sLNhomToiDa; }
            set { sLNhomToiDa = value; }
        }
        private DateTime ngayBD;

        public DateTime NgayBD
        {
            get { return ngayBD; }
            set { ngayBD = value; }
        }
        private DateTime ngayKT;

        public DateTime NgayKT
        {
            get { return ngayKT; }
            set { ngayKT = value; }
        }
        private int trangThai;

        public int TrangThai
        {
            get { return trangThai; }
            set { trangThai = value; }
        }

        public MonHocDTO(int maCD, int maNganh, string tenCD, int slsvToiDa, int slNhomToiDa, DateTime ngayBD, DateTime ngayKT, int TT)
        {
            this.MaCD = maCD;
            this.MaNganh = maNganh;
            this.TenCD = tenCD;
            this.SLSVToiDa = slsvToiDa;
            this.NgayBD = ngayBD;
            this.NgayKT = ngayKT;
            this.TrangThai = TT;
        }
    }
}
