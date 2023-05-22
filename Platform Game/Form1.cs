using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Platform_Game
{
    public partial class Form1 : Form
    {
        private string text;
        private int len = 0;
        private int len2 = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (len < text.Length)
            {
                PlatformGame.Text = PlatformGame.Text + text.ElementAt(len);
                len++;
            }
            else
            {
                timer1.Stop();
                timer2.Start();
            }

            
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (len2 == 0)
            {
                StartGame.Visible = true;
                len2++;
            }
            else if (len2 == 1)
            {
                Control.Visible = true;
                len2++;
            }
            else if (len2 == 2)
            {
                Exit.Visible = true;
                len2++;
            }
            else
            {
                timer2.Stop();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            text = PlatformGame.Text;
            PlatformGame.Text = "";
            timer1.Start();
            StartGame.Visible = false;
            Control.Visible = false;
            Exit.Visible = false;

        }

        private void StartGame_Click(object sender, EventArgs e)
        {
            GameScreen gameWindow = new GameScreen();
            gameWindow.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Control_Click(object sender, EventArgs e)
        {
            ControlsScreen controlsWindow = new ControlsScreen();
            controlsWindow.Show();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
