using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string p1 = txtstart.Text;
            string p2 = txtend.Text;
            string p3 = txtprice.Text;

            double start = double.Parse(p1);
            double end = double.Parse(p2);
            double price = double.Parse(p3);

            double price1 = (end - start) * price;
            double vat = price1 * 21/100;
            double total = price1 + vat;

            prcexc.Text = price1.ToString("0.00");
            prcvat.Text = vat.ToString("0.00");
            prcinc.Text = total.ToString("0.00");




        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtstart.Text = string.Empty;
            txtend.Text = string.Empty;
            txtprice.Text = string.Empty;

            prcexc.Text = string.Empty;
            prcinc.Text = string.Empty;
            prcvat.Text = string.Empty;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
