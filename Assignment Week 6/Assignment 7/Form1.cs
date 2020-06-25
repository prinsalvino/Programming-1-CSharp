using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input1 = txtinput.Text;
            int number = int.Parse(input1);
            int degrees = 0;
            if (radioctok.Checked)
            {
                degrees = Celcius2Kelvin(number);
             
            }
            else if (radioctof.Checked)
            {
                degrees = Celcius2Fahrenheit(number);
               
            }
            else if (radioftoc.Checked)
            {
                degrees = Fahrenheit2Celcius(number);
               
            }
            lblresult.Text = degrees.ToString();
            // ...
        }
        static int Celcius2Kelvin(int number1)
        {
            int kelvin = number1 + 273;
            return kelvin;
        }
        static int Celcius2Fahrenheit(int number1)
        {
            int fahrenheit = number1 * 9 / 5 + 32;
            return fahrenheit;
        }
        static int Fahrenheit2Celcius(int number1)
        {
            int celcius = (number1 - 32) * 5 / 9;
            return celcius;
        }
    }
}
