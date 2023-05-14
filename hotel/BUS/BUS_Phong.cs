
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
    }
}
