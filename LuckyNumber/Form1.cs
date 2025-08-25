using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuckyNumberCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime from = dateTimePicker1.Value;
            DateTime to = DateTime.Now;
            TimeSpan Tspan = to - from;
            double days = Tspan.TotalDays;
            label5.Text = (days / 365).ToString("0");
            
            String datestring = from.Year.ToString() + from.Month.ToString() + from.Day.ToString();
            label7.Text = datestring;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String name = textBox1.Text;
            String age = label5.Text;
            String dts = label7.Text;
            int dateint = Convert.ToInt32(dts);

            

            int sum = 0, remainder = 0;

            while (dateint!=0)
            {
                remainder = dateint % 10;
                sum += remainder; // sum = sum + remainer
                dateint /= 10; // dateint = dateint/10

            }
            int rem = 0,s=0;
            while (sum != 0)
            {
                rem = sum % 10;
                s += rem; // sum = sum + remainer
                sum /= 10; // dateint = dateint/10

            }
            label6.Text = s.ToString();

            MessageBox.Show("Welcome " +name + "\n" + "You Are " + age + " Years Old.\n" + "Your Lucky Number is " + s, "Hooray", MessageBoxButtons.OK);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure Want to Close Program?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }

            
        }

       
    }
}
