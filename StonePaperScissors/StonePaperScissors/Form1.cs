using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StonePaperScissors
{
    public partial class Form1 : Form
    {
        int timer = 0;
        String pc, player;
        int ScorePc = 0, ScorePlayer = 0,random;

        private void button4_Click(object sender, EventArgs e)
        {
            ScorePlayer = 0;
            PlayerScore.Text = "0";
            ScorePc = 0;
            CompScore.Text = "0";
        }

        private void button_click(object sender, EventArgs e)
        {
            player = ((Button)sender).Text;
            Random r = new Random();
            random = r.Next(0, 3);
            switch (random)
            {
                case 0:
                    pc = "Rock";
                    pictureBox5.ImageLocation = "C:\\Users\\omkar\\OneDrive\\Documents\\GitHub\\C-Sharp\\StonePaperScissors\\game\\rock.png";
                    timer1.Stop();
                    if (player == "Rock") {
                        pictureBox4.ImageLocation = "C:\\Users\\omkar\\OneDrive\\Documents\\GitHub\\C-Sharp\\StonePaperScissors\\game\\rock.png";
                        MessageBox.Show("Draw");
                        timer1.Start();
                    }
                    if (player == "Scissors")
                    {
                        pictureBox4.ImageLocation = "C:\\Users\\omkar\\OneDrive\\Documents\\GitHub\\C-Sharp\\StonePaperScissors\\game\\scissors.png";
                        MessageBox.Show("PC wins");
                        ScorePc++;
                        PlayerScore.Text = ScorePlayer.ToString();
                        CompScore.Text = ScorePc.ToString();
                        timer1.Start();
                    }
                    if (player == "Paper")
                    {
                        pictureBox4.ImageLocation = "C:\\Users\\omkar\\OneDrive\\Documents\\GitHub\\C-Sharp\\StonePaperScissors\\game\\paper.png";
                        MessageBox.Show("Player wins");
                        ScorePlayer++;
                        PlayerScore.Text = ScorePlayer.ToString();
                        CompScore.Text = ScorePc.ToString();
                        timer1.Start();
                    }
                    break;

                case 1:
                    pc = "Paper";
                    pictureBox5.ImageLocation = "C:\\Users\\omkar\\OneDrive\\Documents\\GitHub\\C-Sharp\\StonePaperScissors\\game\\paper.png";
                    timer1.Stop();
                    if (player == "Rock")
                    {
                        pictureBox4.ImageLocation = "C:\\Users\\omkar\\OneDrive\\Documents\\GitHub\\C-Sharp\\StonePaperScissors\\game\\rock.png";
                        MessageBox.Show("PC wins");
                        ScorePc++;
                        PlayerScore.Text = ScorePlayer.ToString();
                        CompScore.Text = ScorePc.ToString();
                        timer1.Start();
                        
                    }
                    if (player == "Scissors")
                    {
                        pictureBox4.ImageLocation = "C:\\Users\\omkar\\OneDrive\\Documents\\GitHub\\C-Sharp\\StonePaperScissors\\game\\scissors.png";
                        MessageBox.Show("Player wins");
                        ScorePlayer++;
                        PlayerScore.Text = ScorePlayer.ToString();
                        CompScore.Text = ScorePc.ToString();
                        timer1.Start();
                    }
                    if (player == "Paper")
                    {
                        pictureBox4.ImageLocation = "C:\\Users\\omkar\\OneDrive\\Documents\\GitHub\\C-Sharp\\StonePaperScissors\\game\\paper.png";
                        MessageBox.Show("Draw");
                        timer1.Start();
                    }
                    break;

                case 2:
                    pc = "Scissors";
                    pictureBox5.ImageLocation = "C:\\Users\\omkar\\OneDrive\\Documents\\GitHub\\C-Sharp\\StonePaperScissors\\game\\scissors.png";
                    timer1.Stop();
                    if (player == "Rock")
                    {
                        pictureBox4.ImageLocation = "C:\\Users\\omkar\\OneDrive\\Documents\\GitHub\\C-Sharp\\StonePaperScissors\\game\\rock.png";                       
                        MessageBox.Show("Player wins");
                        ScorePlayer++;
                        PlayerScore.Text = ScorePlayer.ToString();
                        CompScore.Text = ScorePc.ToString();
                        timer1.Start();
                    }
                    if (player == "Scissors")
                    {
                        pictureBox4.ImageLocation = "C:\\Users\\omkar\\OneDrive\\Documents\\GitHub\\C-Sharp\\StonePaperScissors\\game\\scissors.png";
                        MessageBox.Show("Draw");
                        timer1.Start();
                    }
                    if (player == "Paper")
                    {
                        pictureBox4.ImageLocation = "C:\\Users\\omkar\\OneDrive\\Documents\\GitHub\\C-Sharp\\StonePaperScissors\\game\\paper.png";
                        MessageBox.Show("PC wins");
                        ScorePc++;
                        PlayerScore.Text = ScorePlayer.ToString();
                        CompScore.Text = ScorePc.ToString();
                        timer1.Start();
                    }
                    break;
            }
        }

        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer++;
            if (timer == 10) {
                pictureBox4.ImageLocation = "C:\\Users\\omkar\\OneDrive\\Documents\\GitHub\\C-Sharp\\StonePaperScissors\\game\\rock.png";
                pictureBox5.ImageLocation = "C:\\Users\\omkar\\OneDrive\\Documents\\GitHub\\C-Sharp\\StonePaperScissors\\game\\rock.png";
            }
            if (timer == 20) {
                pictureBox4.ImageLocation = "C:\\Users\\omkar\\OneDrive\\Documents\\GitHub\\C-Sharp\\StonePaperScissors\\game\\scissors.png";
                pictureBox5.ImageLocation = "C:\\Users\\omkar\\OneDrive\\Documents\\GitHub\\C-Sharp\\StonePaperScissors\\game\\scissors.png";
            }
            if (timer == 30) {
                pictureBox4.ImageLocation = "C:\\Users\\omkar\\OneDrive\\Documents\\GitHub\\C-Sharp\\StonePaperScissors\\game\\paper.png";
                pictureBox5.ImageLocation = "C:\\Users\\omkar\\OneDrive\\Documents\\GitHub\\C-Sharp\\StonePaperScissors\\game\\paper.png";
                timer1.Stop();
                timer = 0;
                timer1.Start();
            }

        }
    }
}
