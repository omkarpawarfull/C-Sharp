using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Radio_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://bbcmedia.ic.llnwd.net/stream/bbcmedia_radio1_mf_p";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://bbcmedia.ic.llnwd.net/stream/bbcmedia_radio2_mf_p";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://bbcmedia.ic.llnwd.net/stream/bbcmedia_radio3_mf_p";
        }
    }
}
