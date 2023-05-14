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
    public partial class service : UserControl
    {
        private DichVu selectedDV;
        BUS_DichVu bDV = new BUS_DichVu();
        public service()
        {
            InitializeComponent();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
        }

        private void service_Load(object sender, EventArgs e)
        {
            bDV.bindGridView(dgv_service);
            dgv_service.Columns[0].HeaderText = "Mã DV";
            dgv_service.Columns[1].HeaderText = "Tên Dịch Vụ";
            dgv_service.Columns[2].HeaderText = "Giá";
        }

        private void dgv_service_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_service.Rows[e.RowIndex];

                // Kiểm tra rỗng sau đó mới truyền data
                int maDV = 0;
                int.TryParse(row.Cells[2].Value.ToString(), out maDV);

                string tenDV = "";
                if (row.Cells[1].Value != null)
                    tenDV = row.Cells[1].Value.ToString();


                int gia = 0;
                int.TryParse(row.Cells[2].Value.ToString(), out gia);


                selectedDV = new DichVu(maDV, tenDV, gia);
                txt_id.Text = selectedDV.MaDichVu.ToString();
                txt_name.Text = selectedDV.TenDichVu;
                txt_price.Text = selectedDV.GiaDichVu.ToString();

            }

        }
    }
}
