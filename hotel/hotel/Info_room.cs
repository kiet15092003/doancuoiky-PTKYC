using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
namespace hotel
{
    public partial class Info_room : Form
    {
        private int id;
        BUS_Phong bP = new BUS_Phong();
        public Info_room(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pay p = new pay();
            p.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            addservice a = new addservice();
            a.ShowDialog();
        }

        private void Info_room_Load(object sender, EventArgs e)
        {
            Phong phong = bP.getPhongById(id);

            txt_roomID.Text = phong.MaPhong.ToString();
            txt_roomType.Text = phong.LoaiPhong;
            txt_roomMax.Text = phong.SoNguoi.ToString();
            txt_roomPrice.Text = phong.GiaPhong.ToString();
            txt_roomStatus.Text = phong.TrangThai.ToString();

        }
    }
}
