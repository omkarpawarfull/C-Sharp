using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arcade_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            axWindowsMediaPlayer2.URL = @"sounds/background.mp3";
            axWindowsMediaPlayer2.Ctlcontrols.play();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                MoveUp();
            }
            else if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                MoveDown();
            }
            else if (e.KeyCode == Keys.Space) {
                Fire();
            }
        }

        private void MoveUp() {
            Point pos = pictureBoxShip.Location;
            if (pos.Y > 0)
            {
                pos.Y -= 20;
                pictureBoxShip.ImageLocation = @"ship/left.png";
            }
            pictureBoxShip.Location = pos;
        }

        private void MoveDown() {
            Point pos = pictureBoxShip.Location;
            if (pos.Y < panel1.Height - pictureBoxShip.Height)
            {
                pos.Y += 20;
                pictureBoxShip.ImageLocation = @"ship/right.png";
            }
            pictureBoxShip.Location = pos;
        }

        private void Fire() {
            PictureBox fire = new PictureBox();
            fire.Height = 15;
            fire.Width = 25;
            fire.ImageLocation = @"ship/fire.png";
            fire.Location = new Point(pictureBoxShip.Location.X + pictureBoxShip.Width, pictureBoxShip.Location.Y + (pictureBoxShip.Height / 2)-5);
            fire.Name = "bullet";
            panel1.Controls.Add(fire);
        }

        int kindOfEnemy = 4;
        private void CreateEnemy() {
            Random rd = new Random();
            int x = rd.Next(1,kindOfEnemy+1);
            PictureBox enemy = new PictureBox();
            int loc = rd.Next(0, panel1.Height - enemy.Height);
            enemy.SizeMode = PictureBoxSizeMode.StretchImage;
            enemy.Name = "enemy";
            enemy.ImageLocation= @"Aliens/"+x+".png";
            enemy.Location = new Point(panel1.Width-enemy.Width,loc);
            panel1.Controls.Add(enemy);
        }
        
        private void CreateStar()
        {
            Random rd = new Random();
            PictureBox star = new PictureBox();
            star.Width = 10;
            star.Height = 10;
            int loc = rd.Next(0, panel1.Height - star.Height);
            star.SizeMode = PictureBoxSizeMode.StretchImage;
            star.Name = "star";
            star.ImageLocation = @"star/star.png";
            star.Location = new Point(panel1.Width - star.Width, loc);
            star.BackColor = Color.Transparent;
            panel1.Controls.Add(star);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up || e.KeyCode == Keys.W || e.KeyCode == Keys.S) {
                pictureBoxShip.ImageLocation = @"ship/ship.png";
            }
        }
        int count = 0;
        int count2 = 0;
        int score = 0;
        int life = 3;
        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            count2++;
            label3.Text = life.ToString();
            for (int i = 0; i < panel1.Controls.Count; i++) {
                PictureBox pb = ((PictureBox)panel1.Controls[i]);
                if (panel1.Controls[i].Name == "bullet") {
                    if (pb.Location.X + pb.Width > panel1.Width)
                    {
                        panel1.Controls.RemoveAt(i);
                    }
                    else {
                        pb.Location = new Point(pb.Location.X + 5, pb.Location.Y);
                    }
                    for (int x = 0; x < panel1.Controls.Count; x++) {
                        if(panel1.Controls[x].Name=="enemy"){
                            if (pb.Location.X + pb.Width > panel1.Controls[x].Location.X && pb.Location.X + pb.Width < panel1.Controls[x].Location.X + panel1.Controls[x].Width)
                            {
                                if (pb.Location.Y + pb.Height > panel1.Controls[x].Location.Y && pb.Location.Y < panel1.Controls[x].Location.Y + panel1.Controls[x].Height)
                                {
                                    panel1.Controls.Remove(pb);
                                    panel1.Controls.Remove(panel1.Controls[x]);
                                    score++;
                                    label2.Text = score.ToString();
                                }
                            }
                        }
                            
                    }
                }else
                    if (panel1.Controls[i].Name == "enemy")
                    {
                        if (pb.Location.X < 0)
                        {
                            panel1.Controls.RemoveAt(i);
                        }
                        else
                        {
                            pb.Location = new Point(pb.Location.X - 12, pb.Location.Y);
                            if (pb.Location.X > pictureBoxShip.Location.X && pb.Location.X < pictureBoxShip.Location.X + pictureBoxShip.Width) {
                                if (pb.Location.Y > pictureBoxShip.Location.Y && pb.Location.Y < pictureBoxShip.Location.Y + pictureBoxShip.Height) {
                                    panel1.Controls.Remove(pb);
                                    life--;
                                    axWindowsMediaPlayer1.URL = @"sounds/explode.mp3";
                                    axWindowsMediaPlayer1.Ctlcontrols.play();
                                if (life == 0) {
                                        timer1.Stop();
                                        panel2.Visible = true;    
                                    }
                                }
                            }
                        }
                    }else
                        if (panel1.Controls[i].Name == "star")
                    {
                        if (pb.Location.X < 0)
                        {
                            panel1.Controls.RemoveAt(i);
                        }
                        else
                        {
                            pb.Location = new Point(pb.Location.X - 5, pb.Location.Y);
                        }
                    }
            }
            if (count == 30) {
                count = 0;
                CreateEnemy();
            }
            if (count2 == 25)
            {
                count2 = 0;
                CreateStar();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            restart();
        }

        private void restart() {
            if (Application.OpenForms[0] == this) {
                Application.Restart();
            }
        }
    }
}
