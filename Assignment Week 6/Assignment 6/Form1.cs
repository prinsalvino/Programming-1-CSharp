using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnreference_Click(object sender, EventArgs e)
        {
            string input = txtinput.Text;
            int number = int.Parse(input);
            Square(ref number);
            lblresult.Text = number.ToString();
        }
        static void Square(ref int number1)
        {
            int square = number1 * number1;
            number1 = square;
        }

        private void btnreferenceout_Click(object sender, EventArgs e)
        {
            string input = txtinput.Text;
            int number = int.Parse(input);
            int square;
            Square(number, out square);
            lblresult.Text = square.ToString();

        }
        static void Square (int number,out int square )
        {
            square = number * number;
        }

        private void btnvalue_Click(object sender, EventArgs e)
        {
            string input = txtinput.Text;
            int number = int.Parse(input);

            int square = Square(number);
            lblresult.Text = square.ToString();
        }
        static int Square(int number)
        {
            int square = number * number;
            return square;
        }
    }
}
