using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDon
    {
        private int maHoaDon;
        private int tongTien;
        private DateTime ngayLap;

        public HoaDon() { }

        public HoaDon(int maHoaDon, int tongTien, DateTime ngayLap)
        {
            this.maHoaDon = maHoaDon;
            this.tongTien = tongTien;
            this.ngayLap = ngayLap;
        }

        public int MaHoaDon { get => maHoaDon; set => maHoaDon = value; }
        public int TongTien { get => tongTien; set => tongTien = value; }
        public DateTime NgayLap { get => ngayLap; set => ngayLap = value; }
    }
}
