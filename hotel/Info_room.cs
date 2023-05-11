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
    public partial class Info_room : Form
    {
        public Info_room()
        {
            InitializeComponent();
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
    }
}
