using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PinPon2
{
    public partial class StartScreen : Form
    {
        //gamemode 1 = player vs player, gamemode 2 = player vs ai
        private int gamemode;
        public int gametime = 120;
        public int ball_speedx = 1;
        public int ball_speedy = 1;
        public StartScreen()
        {
            InitializeComponent();
        }
        private void btn_playervsplayer_Click(object sender, EventArgs e)
        {
            gamemode = 1;
            player2name_txt.Text = "Player2";
            StartbuttonActions();
        }

        private void btn_playervsai_Click(object sender, EventArgs e)
        {
            gamemode = 0;
            player2name_txt.Text = "Computer";
            StartbuttonActions();
        }

        private void menubtn_Click(object sender, EventArgs e)
        {
            gamepanel.Visible = false;
            gametimer.Enabled=false;
            balltimer.Enabled=false;
            gametime = 120;
            timer_txt.Text = gametime.ToString();
            ball.Location = new Point(475, 220);
            ball_speedx = 1;
        }

        private void gametimer_Tick(object sender, EventArgs e)
        {            
            timer_txt.Text = gametime.ToString();
            gametime -= 1;
        }

        private void balltimer_Tick(object sender, EventArgs e)
        {
            ball.Left += ball_speedx;
            ball.Top += ball_speedy;
            ball_bounce();
        }

        public void ball_bounce()
        {
            if (ball.Bottom >= bottomwall.Top)
            {
                ball_speedy = -ball_speedy;
                if (ball_speedx < 0) { ball_speedx -= 1; }
                else { ball_speedx += 1; }
            }
            else if (ball.Top <= topwall.Bottom) 
            {
                ball_speedy = -ball_speedy;
                if (ball_speedx < 0) { ball_speedx -= 1; }
                else { ball_speedx += 1; }
            }
            else if(ball.Right >= gamepanel.Right) 
            {
                ball_speedx = -ball_speedx;
                if (ball_speedx < 0) { ball_speedx -= 1; }
                else { ball_speedx += 1; }
            }
            else if (ball.Left <= gamepanel.Left)
            {
                ball_speedx = -ball_speedx;
                if (ball_speedx < 0) { ball_speedx -= 1; }
                else { ball_speedx += 1; }
            }
        }
        private void StartbuttonActions()
        {
            gamepanel.Visible = true;
            gametimer.Enabled = true;
            balltimer.Enabled = true;
        }
    }
}
