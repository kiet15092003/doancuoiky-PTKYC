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
    public partial class pay : Form
    {
        public pay()
        {
            InitializeComponent();
        }

        private void pay_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you agree to make the payment?", "Payment Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Payment successful!");

                DialogResult printResult = MessageBox.Show("Do you want to print the invoice?", "Print Invoice", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (printResult == DialogResult.Yes)
                {
                    //Add code to print the invoice here
                }
            }

            this.Close();
        }
    }
}
