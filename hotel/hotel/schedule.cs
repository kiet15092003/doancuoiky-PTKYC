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
    public partial class schedule : Form
    {
        public schedule()
        {
            InitializeComponent();
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }
        BUS_KhachHang bKH = new BUS_KhachHang();
        BUS_Phong bP = new BUS_Phong();

        private void button1_Click(object sender, EventArgs e)
        {
         //   (ngayDat.Value)
            KhachHang kh = new KhachHang();
            kh.NgayDatPhong = ngayDat.Value;
            kh.NgayTraphong = ngayTra.Value;
            bP.updateTrangThaiPhong(kh.NgayDatPhong.Date, kh.NgayTraphong.Date);
            this.Close();
        }

        private void schedule_Load(object sender, EventArgs e)
        {

        }
    }
}
