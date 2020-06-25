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
        const int MAX = 6000;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnthrow_Click(object sender, EventArgs e)
        {
            Random r = new Random();

            int[] dice = new int[6];

            for (int i = 0; i < dice.Length; i++)
            {
                dice[i] = 0;
            }

            for (int i = 0; i < MAX; i++)
            {
                int rnd = r.Next(1, 7);
                dice[rnd - 1]++;
            }


            for (int i = 0; i < dice.Length; i++)
            {
                lblprint.Text = lblprint.Text + string.Format("Number throws of value {0} = {1}\n",(i + 1), dice[i]);
            }
        }
    }
}
