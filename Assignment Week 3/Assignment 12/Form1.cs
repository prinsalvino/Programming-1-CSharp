using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const int price = 12;
        
        private void button1_Click(object sender, EventArgs e)
        {
            string input1 = txtage.Text;

            int age = int.Parse(input1);
            int halfprice = price * 50 / 100;

            if (age < 5 )
            {
                lblprice.Text = "Free";
            }
            if (age >= 5 && age <= 12)
            {
                lblprice.Text = halfprice.ToString("0.00");
            }
            if (age>=13 && age<=54)
            {
                lblprice.Text = price.ToString("0.00");
            }   
            if (age >= 55)
            {
                lblprice.Text = "Free";
            }
        }
    }
}
