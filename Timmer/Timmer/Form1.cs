using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timmer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
        int hour, min, sec;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sec++;
            label3.Text = AddZero(sec);
            if (sec == 60) {
                sec = 0;
                label3.Text = "00";
                min++;
                label2.Text = AddZero(min);
            }

            if (min == 60) {
                min = 0;
                label2.Text = "00";
                hour++;
                label1.Text = AddZero(hour);
            }
        }

        private string AddZero(int m)
        {
            String value = "";
            if (m < 10)
            {
                value = "0" + m.ToString();
            }
            else {
                value = m.ToString();
            }
            return value;
        }
    }
}
