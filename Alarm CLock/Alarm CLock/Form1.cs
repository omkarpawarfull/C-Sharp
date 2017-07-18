using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarm_CLock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int min, sec, hour;
        String AlarmMin, AlarmHour;

        private void button1_Click(object sender, EventArgs e)
        {
            AlarmMin = comboBox2.Text;
            AlarmHour = comboBox1.Text;
            //MessageBox.Show("H : M"+AlarmHour+" "+AlarmMin);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            min = DateTime.Now.Minute;
            sec = DateTime.Now.Second;
            hour = DateTime.Now.Hour;
            label2.Text = hour.ToString();
            label3.Text = min.ToString();
            label4.Text = sec.ToString();
            ring_alarm();
        }

        void ring_alarm() {
            if (min.ToString() == AlarmMin && hour.ToString() == AlarmHour && sec.ToString() == "0") {
                axWindowsMediaPlayer1.URL = "C:\\Users\\omkar\\OneDrive\\Documents\\GitHub\\C-Sharp\\Alarm CLock\\alarm-sound.mp3";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            for (int i = 0; i < 24; i++) {
                comboBox1.Items.Add(i);
            }
            for (int j = 0; j < 60; j++)
            {
                comboBox2.Items.Add(j);
            }
        }
    }
}
