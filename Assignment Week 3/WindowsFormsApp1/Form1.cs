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
        const int football = 175;
        const int handball = 225;
        private void button1_Click(object sender, EventArgs e)
        {
            string input1 = txtage.Text;
            string input2 = txtmember.Text;

            int age = int.Parse(input1);
            int member = int.Parse(input2);

            int oldfootball = football - 25;
            int oldhandball = handball - 25;
            int memberfootball = football - 20;
            int memberhandball = handball - 20;
            int bothfootball = football - 25 - 20;
            int bothhandball = handball - 25 - 20;

            //for football
            if (rbfootball.Checked)
            {
                labelfee.Text = football.ToString("0.00");
            }
            if (rbfootball.Checked == true && age >= 40)
            {
                labelfee.Text = oldfootball.ToString("0.00");
            }
            if (rbfootball.Checked == true && member >= 10)
            {
                labelfee.Text = memberfootball.ToString("0.00");
            }
            if (rbfootball.Checked == true && age >= 40 && member >= 10)
            {
                labelfee.Text = bothfootball.ToString("0.00");
            }
            //for handball

            if (rbhandball.Checked == true)
            {
                labelfee.Text = handball.ToString("0.00");
            }
            if (rbhandball.Checked == true && age >= 40)
            {
                labelfee.Text = oldhandball.ToString("0.00");
            }
            if (rbhandball.Checked == true && member >= 10)
            {
                labelfee.Text = memberhandball.ToString("0.00");
            }
            if (rbhandball.Checked == true && age >= 40 && member >= 10)
            {
                labelfee.Text = bothhandball.ToString("0.00");
            }
        }
    }
}
