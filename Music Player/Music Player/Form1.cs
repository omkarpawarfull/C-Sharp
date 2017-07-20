using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Player
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static List<String> songs = new List<String>();
        private void btnPause_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fb = new FolderBrowserDialog();
            if (fb.ShowDialog() == DialogResult.OK) {
                var path = fb.SelectedPath;
                var file = Directory.GetFiles(path);

                foreach (var item in file) {
                    songs.Add(item);
                }

                foreach (var item in file) {
                    list.Items.Add(item.Split('\\').LastOrDefault());

                }
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
        
            foreach (var item in songs) {
                if (item.Contains(list.SelectedItem.ToString())) {
                    axWindowsMediaPlayer1.URL=item;
                    break;
                }
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            list.Items.Clear();
            Random rd = new Random();

            for (int i = 0; i < songs.Count; i++) {
                int j = rd.Next(i,songs.Count);
                String temp = songs[i];
                songs[i] = songs[j];
                songs[j] = temp;
            }

            foreach (var item in songs)
            {
                list.Items.Add(item.Split('\\').LastOrDefault());

            }
        }
    }
}
