using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Platform_Game
{
    public partial class GameScreen : Form
    {
        bool goLeft, goRight, jumping, isGameOver, midair = false;

    //    int jumpSpeed;
        int force;
        int score = 0;
        int playerSpeed = 7;
        int maxForce = 10;

        int horizontalSpeed = 3;
        int verticalSpeed = 2;
        int platformBSpeed = 4;

        int enemy2Speed = 2;
        int enemy3Speed = 2;

        int len;

        public GameScreen()
        {
            InitializeComponent();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void MainGameTimeEvent(object sender, EventArgs e)
        {
            textScore.Text = "Score: " + score;

        //    player.Top += jumpSpeed;

            if (goLeft == true)
            {
                player.Left -= playerSpeed;
            }
            if(goRight == true)
            {
                player.Left += playerSpeed;
            }

            force = Math.Min(maxForce, force + 1);
            player.Top += force;

      
            foreach(Control x in this.Controls)
            {
                if(x is PictureBox)
                {
                    
                    if((string)x.Tag == "platform")
                    {
                        if (player.Bounds.IntersectsWith(x.Bounds))
                        {
                            // Collision detected
                            int overlapLeft = x.Right - player.Left;
                            int overlapRight = player.Right - x.Left;
                            int overlapTop = x.Bottom - player.Top;
                            int overlapBottom = player.Bottom - x.Top;

                            // Check which side of the player is colliding with x
                            if (overlapLeft < overlapRight && overlapLeft < overlapTop && overlapLeft < overlapBottom)
                            {
                                // Collision on the left side of player
                                
                                player.Left = x.Right;


                            }
                            else if (overlapRight < overlapLeft && overlapRight < overlapTop && overlapRight < overlapBottom)
                            {
                                // Collision on the right side of player
                                force = -13;
                               
                                player.Left = x.Left - player.Width;
                            }
                            if (overlapTop < overlapLeft && overlapTop < overlapRight && overlapTop < overlapBottom)
                            {
                                // Collision on the top side of player
                                force = 0;
                                player.Top = x.Bottom;
                            }
                            else if (overlapBottom < overlapLeft && overlapBottom < overlapRight && overlapBottom < overlapTop)
                            {
                                // Collision on the bottom side of player
                                force = 5;
                                player.Top = x.Top - player.Height;
                                midair = false;
                            }

                            if ((string)x.Name == "horizontalPlatform" && !goLeft || (string)x.Name == "horizontalPlatform" && !goRight)
                            {
                                player.Left += horizontalSpeed;
                            }
                            x.BringToFront();
                        }

                    }
                    if ((string)x.Tag == "wall")
                    {
                        if (player.Bounds.IntersectsWith(x.Bounds))
                        {
                            // Collision detected
                            int overlapLeft = x.Right - player.Left;
                            int overlapRight = player.Right - x.Left;
                            int overlapTop = x.Bottom - player.Top;
                            int overlapBottom = player.Bottom - x.Top;

                            // Check which side of the player is colliding with x
                            if (overlapLeft < overlapRight && overlapLeft < overlapTop && overlapLeft < overlapBottom)
                            {
                                // Collision on the left side of player
                                player.Left = x.Right;
                           //     jumpSpeed = 0;
                                force += 1;
                                player.Left = x.Right;


                            }
                            else if (overlapRight < overlapLeft && overlapRight < overlapTop && overlapRight < overlapBottom)
                            {
                                // Collision on the right side of player
                                player.Left = x.Left;
                         //     jumpSpeed = 0;
                                force += 1;
                                player.Left = x.Left - player.Width;
                            }

                        }
                    }
                   
                    if ((string)x.Tag == "coin")
                    {
                        if (player.Bounds.IntersectsWith(x.Bounds) && x.Visible == true)
                        {
                            x.Visible = false;
                            score++;
                        }
                    }

                    if((string)x.Tag == "enemy")
                    {
                        if (player.Bounds.IntersectsWith(x.Bounds))
                        {
                            // Collision detected
                            int overlapLeft = x.Right - player.Left;
                            int overlapRight = player.Right - x.Left;
                            int overlapTop = x.Bottom - player.Top;
                            int overlapBottom = player.Bottom - x.Top;

                            if (overlapBottom < overlapLeft && overlapBottom < overlapRight && overlapBottom < overlapTop)
                            {
                                // Collision on the bottom side of player
                            
                                x.Visible = false;
                                x.Parent = null;

                            }
                            else
                            {
                                gameTimer.Stop();
                                isGameOver = true;
                                textBox2.Text = "The enemies killed you!";
                            }
                        }
                    }

                    if((string)x.Tag == "water")
                    {
                        if (player.Bounds.IntersectsWith(x.Bounds))
                        {
                            gameTimer.Stop();
                            isGameOver = true;
                            textBox2.Text = "You drowned!";
                        }
                    }
                    if ((string)x.Tag == "platformB")
                    {
                        if (player.Bounds.IntersectsWith(x.Bounds))
                        {
                            x.Top += platformBSpeed;

                            force = 5;
                            player.Top = x.Top - player.Height;
                            midair = false;
                        }
                    }
                }
            }
            horizontalPlatform.Left += horizontalSpeed;

            if(horizontalPlatform.Left < 500 || horizontalPlatform.Left > 690)
            {
                horizontalSpeed = -horizontalSpeed;
            }
            
            verticalPlatform.Top += verticalSpeed;

            if(verticalPlatform.Top < 312 || verticalPlatform.Top > 500)
            {
                verticalSpeed = -verticalSpeed;
            }

            enemy2.Left -= enemy2Speed;

            if(enemy2.Left < pictureBox5.Left + 10 || enemy2.Left + enemy2.Width > pictureBox5.Left + pictureBox5.Width - 10)
            {
                enemy2Speed = -enemy2Speed;
            }

            enemy3.Left -= enemy3Speed;

            if(enemy3.Left < pictureBox20.Left + 5 || enemy3.Left + enemy3.Width > pictureBox20.Left + pictureBox20.Width - 40)
            {
                enemy3Speed = -enemy3Speed;
            }

            if (player.Bounds.IntersectsWith(door.Bounds) && score == 20)
            {
                gameTimer.Stop();
                isGameOver = true;
                textBox3.Text = "You won!";
            }
        }

        private void Restartbtn_Click(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void player_Click(object sender, EventArgs e)
        {

        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if(e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.Up && jumping == false && !midair)
            {
                force = -12;
            
                jumping = true;
                midair = true;
            }
            
            if(e.KeyCode  == Keys.Escape)
            {
                this.Close();
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if(e.KeyCode == Keys.Up)
            {
                jumping = false;
            }
            if(e.KeyCode == Keys.R)
            {
                RestartGame();
            }
        }
        private void RestartGame()
        {
            this.Close();
            GameScreen gameWindow = new GameScreen();
            gameWindow.Show();
        }
    }
}
