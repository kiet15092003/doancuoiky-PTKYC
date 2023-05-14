using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class DAL_Phong : DBConnect
    {
        public void bindGridViewByStatus(DataGridView dataGridView)
        {
            conn.Open();
            string query = "SELECT maPhong, loaiPhong, soNguoi, giaPhong FROM Phong WHERE trangThai = 0";
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView.DataSource = dataTable;
            conn.Close();
        }

        public Phong getPhongById(int maPhong)
        {
            conn.Open();
            string query = "SELECT * FROM Phong WHERE maPhong = @MaPhong";
            Phong phong = null;

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@MaPhong", maPhong);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                phong = new Phong();
                phong.MaPhong = Convert.ToInt32(reader["maPhong"]);
                phong.LoaiPhong = reader["loaiPhong"].ToString();
                phong.SoNguoi = Convert.ToInt32(reader["soNguoi"]);
                phong.GiaPhong = Convert.ToInt32(reader["giaPhong"]);
                phong.TrangThai = Convert.ToBoolean(reader["trangThai"]);
            }

            reader.Close();
            return phong;
        }

    }
}
