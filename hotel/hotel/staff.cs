using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace hotel
{
    public partial class staff : UserControl
    {
        BUS_NhanVien bNV = new BUS_NhanVien();
        private NhanVien selectedNV;
        public staff()
        {
            InitializeComponent();
        }

        private void ck_male_CheckedChanged(object sender, EventArgs e)
        {
            if (ck_male.Checked)
            {
                ck_female.Checked = false;
            }
        }

        private void ck_female_CheckedChanged(object sender, EventArgs e)
        {
            if (ck_female.Checked)
            {
                ck_male.Checked = false;
            }
        }

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void staff_Load(object sender, EventArgs e)
        {
            bNV.bindGridView(dgv_emp);
            dgv_emp.Columns[0].HeaderText = "Mã NV";
            dgv_emp.Columns[1].HeaderText = "Họ và tên";
            dgv_emp.Columns[2].HeaderText = "Ngày sinh";
            dgv_emp.Columns[3].HeaderText = "Giới tính";
            dgv_emp.Columns[4].HeaderText = "CCCD";
            dgv_emp.Columns[5].HeaderText = "SĐT";
        }

        private void dgv_emp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_emp.Rows[e.RowIndex];

                // Kiểm tra rỗng sau đó mới truyền data
                string maNV = "";
                if (row.Cells[0].Value != null)
                    maNV = row.Cells[0].Value.ToString();

                string tenNV = "";
                if (row.Cells[1].Value != null)
                    tenNV = row.Cells[1].Value.ToString();

                DateTime ngaySinh = DateTime.MinValue;
                DateTime.TryParse(row.Cells[2].Value.ToString(), out ngaySinh);

                bool gioiTinh = false;
                bool.TryParse(row.Cells[3].Value.ToString(), out gioiTinh);

                string cccd = "";
                if (row.Cells[4].Value != null)
                    cccd = row.Cells[4].Value.ToString();

                string sdt = "";
                if (row.Cells[5].Value != null)
                    sdt = row.Cells[5].Value.ToString();

                selectedNV = new NhanVien(maNV, tenNV, ngaySinh, gioiTinh, cccd, sdt);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            MessageBox.Show(selectedNV.HoTen);
        }
    }
}
