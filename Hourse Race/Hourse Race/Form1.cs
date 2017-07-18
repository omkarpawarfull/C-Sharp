using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hourse_Race
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rand = new Random();
        int finish;
        private void timer1_Tick(object sender, EventArgs e)
        {
            horse1.Left += rand.Next(5, 15);
            horse2.Left += rand.Next(5, 15);
            horse3.Left += rand.Next(5, 15);
            int horseWidth = horse1.Width;
            finish = label4.Left;
            if (horse1.Left + horseWidth >= finish) {
                timer1.Stop();
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                MessageBox.Show("1st horse won!!");
            }
            if (horse2.Left + horseWidth >= finish)
            {
                timer1.Stop();
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                MessageBox.Show("2nd horse won!!");
            }
            if (horse3.Left + horseWidth >= finish)
            {
                timer1.Stop();
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                MessageBox.Show("3rd horse won!!");
            }

            if (horse1.Left > horse2.Left && horse1.Left > horse3.Left) {
                label5.Text = "Horse 1 is ahead of Others";
            }
            if (horse2.Left > horse1.Left && horse2.Left > horse3.Left)
            {
                label5.Text = "Horse 2 is ahead of Others";
            }
            if (horse3.Left > horse2.Left && horse3.Left > horse1.Left)
            {
                label5.Text = "Horse 3 is ahead of Others";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            axWindowsMediaPlayer1.URL = "C:\\Users\\omkar\\OneDrive\\Documents\\GitHub\\C-Sharp\\Hourse Race\\horse.mp3";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
