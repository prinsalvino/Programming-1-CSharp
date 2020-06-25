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
        int[] arr = new int[20];
        Random r = new Random();
        
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string input = txtinput.Text;
            int compare = int.Parse(input);

            for (int i = 0; i < arr.Length; i++)
            {
                if (compare > arr[i])
                {
                    arr[i] = arr[i] + 10;
                }
                else if (compare<arr[i])
                {
                    arr[i] = arr[i] - 5;
                }
                lblafter.Text = lblafter.Text + string.Format("Element {0} : {1}\n",i, arr[i]);
            }
            btncompare.Enabled = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            for (int i = 0; i < arr.Length; i++)
            {
                int rnd = r.Next(0, 500);
                arr[i] = rnd;
           
                lblbefore.Text = lblbefore.Text + string.Format("Element {0}: {1} \n", i, arr[i] );                   
            }
           
        }
    }
}
