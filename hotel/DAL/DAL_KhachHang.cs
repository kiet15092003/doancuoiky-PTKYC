using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_KhachHang : DBConnect
    {

        public bool themKhachHang(KhachHang kh)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("dbo.KhachHang_CRUD", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@StatementType", "INSERT");
            cmd.Parameters.AddWithValue("@Ma_KH", null);
            cmd.Parameters.AddWithValue("@HoTen_KH", kh.HoTen);
            cmd.Parameters.AddWithValue("@Gioi_tinh ", kh.GioiTinh);
            cmd.Parameters.AddWithValue("@Dia_chi", kh.DiaChi);
            cmd.Parameters.AddWithValue("@Que_quan", kh.QueQuan);
            cmd.Parameters.AddWithValue("@sdt", kh.Sdt);
            cmd.Parameters.AddWithValue("@CCCD", kh.Cccd);
            cmd.Parameters.AddWithValue("@Ngay_dat_phong", kh.NgayDatPhong);
            cmd.Parameters.AddWithValue("@Ngay_tra_phong", kh.NgayTraphong);

            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                conn.Close();
                return true;
            }
            conn.Close();
            return false;
        }

        public bool xoaKhachHang(KhachHang kh)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("dbo.KhachHang_CRUD", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@StatementType", "DELETE");
            cmd.Parameters.AddWithValue("@Ma_KH", kh.MaKH);
            cmd.Parameters.AddWithValue("@HoTen_KH", kh.HoTen);
            cmd.Parameters.AddWithValue("@Gioi_tinh ", kh.GioiTinh);
            cmd.Parameters.AddWithValue("@Dia_chi", kh.DiaChi);
            cmd.Parameters.AddWithValue("@Que_quan", kh.QueQuan);
            cmd.Parameters.AddWithValue("@sdt", kh.Sdt);
            cmd.Parameters.AddWithValue("@CCCD", kh.Cccd);
            cmd.Parameters.AddWithValue("@Ngay_dat_phong", kh.NgayDatPhong);
            cmd.Parameters.AddWithValue("@Ngay_tra_phong", kh.NgayTraphong);

            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                conn.Close();
                return true;
            }
            conn.Close();
            return false;
        }

    }
}
