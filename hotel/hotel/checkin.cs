using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel
{
    public partial class checkin : UserControl
    {
        BUS_Phong bP = new BUS_Phong();
        public checkin()
        {
            InitializeComponent();

        }

        private void checkin_Load(object sender, EventArgs e)
        {
            bP.bindGridViewByStatus(dgv_Phong);
            dgv_Phong.Columns[0].HeaderText = "Mã Phòng";
            dgv_Phong.Columns[1].HeaderText = "Loại";
            dgv_Phong.Columns[2].HeaderText = "Số người";
            dgv_Phong.Columns[3].HeaderText = "Giá";

            tt1.Text = bP.getPhongById(1).TrangThai.ToString();
            tt2.Text = bP.getPhongById(2).TrangThai.ToString();
            tt3.Text = bP.getPhongById(3).TrangThai.ToString();
            tt4.Text = bP.getPhongById(4).TrangThai.ToString();
            tt5.Text = bP.getPhongById(5).TrangThai.ToString();
            tt6.Text = bP.getPhongById(6).TrangThai.ToString();
            tt7.Text = bP.getPhongById(7).TrangThai.ToString();
            tt8.Text = bP.getPhongById(8).TrangThai.ToString();
            tt9.Text = bP.getPhongById(9).TrangThai.ToString();
            tt10.Text = bP.getPhongById(10).TrangThai.ToString();


        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox10_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {
        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Info_room room = new Info_room(6);
            room.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            customer c = new customer();
            c.ShowDialog();
        }

        private void btn_r1_Click(object sender, EventArgs e)
        {
            Info_room room = new Info_room(1);
            room.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Info_room room = new Info_room(2);
            room.ShowDialog();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Info_room room = new Info_room(3);
            room.ShowDialog();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Info_room room = new Info_room(4);
            room.ShowDialog();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Info_room room = new Info_room(5);
            room.ShowDialog();

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Info_room room = new Info_room(7);
            room.ShowDialog();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Info_room room = new Info_room(8);
            room.ShowDialog();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Info_room room = new Info_room(9);
            room.ShowDialog();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Info_room room = new Info_room(10);
            room.ShowDialog();

        }

        private void dgv_Phong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
