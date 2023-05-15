﻿using DTO;
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

        public KhachHang getKhachHangById(int maPhong)
        {
            conn.Open();
            string query = "SELECT * FROM KhachHang WHERE maPhong = @MaPhong";
            KhachHang kh = null;

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@MaPhong", maPhong);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                kh = new KhachHang();
                kh.MaKH = reader["maKH"].ToString();
                kh.MaPhong = Convert.ToInt32(reader["maPhong"]);
                kh.HoTen = reader["hoTen"].ToString();
                kh.GioiTinh = Convert.ToBoolean(reader["gioiTinh"]);
                kh.DiaChi = reader["diaChi"].ToString();
                kh.Sdt = reader["sdt"].ToString();
                kh.Cccd = reader["cccd"].ToString();
                kh.DiaChi = reader["diaChi"].ToString();
                kh.NgayDatPhong = Convert.ToDateTime(reader["ngayDatPhong"]);
                kh.NgayTraphong = Convert.ToDateTime(reader["ngayTraPhong"]);

            }

            reader.Close();
            conn.Close();

            return kh;
        }
    }
}
