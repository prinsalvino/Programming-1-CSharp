using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            string input1 = textBox1.Text;
            string input2 = textBox2.Text;
            string input3 = textBox3.Text;

            double nmr1 = double.Parse(input1);
            double nmr2 = double.Parse(input2);
            double nmr3 = double.Parse(input3);

            double avg = (nmr1 + nmr2 + nmr3) / 3;

            lblavg.Text = avg.ToString();


        }
    }
}
