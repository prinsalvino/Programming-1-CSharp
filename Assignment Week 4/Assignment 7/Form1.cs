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
            int input = int.Parse(txtinput.Text);
            string square = "";

            for (int x = 0; x < input; x++)
            {
                square = square + "X";

                if (x == 0 || x == input - 1)
                {
                    for (int y = 0; y < input-2; y++)
                    {
                        square = square + "X";

                    }
                }

                else
                {
                    for (int y = 0; y < input-2; y++)
                    {
                        square = square + " ";
                    }
                    
                }
                square = square + "X\n";

            }
            lblx.Text = square;
        }
    }
}
