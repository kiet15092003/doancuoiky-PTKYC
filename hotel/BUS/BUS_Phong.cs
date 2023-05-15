
using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class BUS_Phong
    {
        DAL_Phong dP = new DAL_Phong();


        public void bindGridViewByStatus(DataGridView dataGridView)
        {
            dP.bindGridViewByStatus(dataGridView);
        }

        public Phong getPhongById(int maPhong)
        {
            return dP.getPhongById(maPhong);
        }

        public void updateTrangThaiPhong (DateTime ngayDat, DateTime ngayTra)
        {
            dP.updateTrangThaiPhong(ngayDat, ngayTra);        
        }

        public bool themPhong(Phong phong)
        {
            return dP.themPhong(phong);
        }

        public bool xoaPhong(Phong phong)
        {
            return dP.xoaPhong(phong);
        }

        public bool suaPhong(Phong phong)
        {
            return dP.suaPhong(phong);
        }

        public void bindGridView(DataGridView dataGridView)
        {
            dP.bindGridView(dataGridView);
        }

        public void bindGridViewbySearch(DataGridView dataGridView, string name)
        {
            dP.bindGridViewbySearch(dataGridView, name);
        }
    }
}
