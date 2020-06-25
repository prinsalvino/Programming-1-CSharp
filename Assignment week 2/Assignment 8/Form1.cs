using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input1 = textBox1.Text;
            string input2 = textBox2.Text;

            int xshirt = int.Parse(input1);
            int xjeans = int.Parse(input2);

            int tshirt = xshirt * 30;
            int jeans = xjeans * 100;
            int price = tshirt + jeans;
            int vat = price * 21 / 100;
            int total = price + vat;

            lblprc.Text = price.ToString("0.00");
            lblvat.Text = vat.ToString("0.00");
            lbltotal.Text = total.ToString("0.00");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
