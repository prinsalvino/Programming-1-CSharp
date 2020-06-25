using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();




        }
        
        private void btncalculatevat_Click(object sender, EventArgs e)
        {
            string input = txtinput.Text;
            double price = double.Parse(input);

            double thevat = price * 21 / 100;

            double total = thevat + price;

            lblprice.Text = price.ToString("0.00");
            lblvat.Text = thevat.ToString("0.00");
            lbltotal.Text = total.ToString("0.00");
           




        }
    }
}
