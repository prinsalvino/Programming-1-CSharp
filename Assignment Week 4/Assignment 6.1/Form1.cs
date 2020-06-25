using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_6._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            string input = txtinput.Text;
            double amount = double.Parse(input);

            for (double i = 1; i <= 5; i++)
            {
                double interest = (amount * 0.05);
                amount = amount + interest;
            }
            lbltotal.Text = amount.ToString("€0.00");

        }
    }
}
