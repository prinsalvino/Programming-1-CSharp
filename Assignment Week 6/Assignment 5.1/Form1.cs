using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_5._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private  void btnplus_Click(object sender, EventArgs e)
        {
            string input = txt1.Text;
            int number1 = int.Parse(input);
            string input2 = txt2.Text;
            int number2 = int.Parse(input2);
            int plus = CalcPlus(number1, number2);
            lblresult.Text = plus.ToString();
        }
        static int CalcPlus(int nmbr1, int nmbr2)
        {
            int plus = (nmbr1 + nmbr2);
            return plus;
        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            string input = txt1.Text;
            int number1 = int.Parse(input);
            string input2 = txt2.Text;
            int number2 = int.Parse(input2);
            int minus = CalcMinus(number1, number2);
            lblresult.Text = minus.ToString();
        }
        static int CalcMinus(int nmr1,int nmr2)
        {
            int minus = nmr1 - nmr2;
            return minus;
        }

        private void btnmultiple_Click(object sender, EventArgs e)
        {
            string input = txt1.Text;
            int number1 = int.Parse(input);
            string input2 = txt2.Text;
            int number2 = int.Parse(input2);
            int multiply = CalcMultiply(number1, number2);
            lblresult.Text = multiply.ToString();

        }
        static int CalcMultiply(int nmr1 , int nmr2)
        {
            int multiply = nmr1 * nmr2;
            return multiply;
        }

        private void btndivide_Click(object sender, EventArgs e)
        {
            string input = txt1.Text;
            int number1 = int.Parse(input);
            string input2 = txt2.Text;
            int number2 = int.Parse(input2);
            double divide = CalcDivide(number1, number2);
            lblresult.Text = divide.ToString();
        }
        static double CalcDivide(int nmr1, int nmr2)
        {
            double divide = nmr1 / (double)nmr2;
            return divide;
        }
    }
}
