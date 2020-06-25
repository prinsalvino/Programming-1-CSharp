using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_8._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncompare_Click(object sender, EventArgs e)
        {

            string input = txtinput.Text;
            int number = int.Parse(input);

            int sum = 0;
            int total = 0;

            string equal = "The Sum are Equals";
            string notequal = "The Sum Are not Equals";



            for (int i = 0; i < number; i++)
            {
                sum++;
                total = total + sum;
            }
            lblresults.Text = total.ToString();


            int compare = number * (number + 1) / 2;

            lblcompare.Text = compare.ToString();

            if (compare == total)
            {
                lblprint.Text = equal;
            }
            else
            {
                lblprint.Text = notequal;
            }
        }
    }
}
