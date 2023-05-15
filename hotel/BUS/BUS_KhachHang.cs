using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_KhachHang
    {
        DAL_KhachHang dKH = new DAL_KhachHang();
        public bool themKhachHang(KhachHang kh)
        {
            return dKH.themKhachHang(kh);
        }
        public KhachHang getKhachHangById(int maPhong)
        {
            return dKH.getKhachHangById(maPhong);
        }

    }
}
