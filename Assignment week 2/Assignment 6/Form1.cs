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

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            int seconds = int.Parse(input);

            int hours = seconds / 3600;
            seconds =  seconds - hours * 3600;
            int minutes = seconds / 60;
            seconds = seconds - minutes * 60;
           

            lblhours.Text = hours.ToString("00");
            lblminutes.Text = minutes.ToString("00");
            lblseconds.Text = seconds.ToString("00");
        }
    }
}
