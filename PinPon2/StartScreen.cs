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
        public int ball_speedx = 3;
        public int ball_speedy = 3;
        public int intscore1 = 0, intscore2 = 0;
        public StartScreen()
        {
            InitializeComponent();
            this.KeyPreview = true;
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
            movement_timer.Enabled = false;
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
            else if(ball.Left<=racket1.Right && ball.Left>= racket1.Left && ball.Top >= racket1.Top && ball.Bottom <= racket1.Bottom)
            {
                ball_speedx = -ball_speedx;
            }
            else if (ball.Right >= racket2.Left && ball.Right <= racket2.Right && ball.Top >= racket2.Top && ball.Bottom <= racket2.Bottom)
            {
                ball_speedx = -ball_speedx;
            }

            else if(ball.Right >= gamepanel.Right+10) 
            {
                ball.Location = new Point(475, 220);
                ball_speedx = 3;
                intscore1 += 1;
                score1.Text = intscore1.ToString();
            }
            else if (ball.Left <= gamepanel.Left-10)
            {
                ball.Location = new Point(475, 220);
                ball_speedx = -3;
                intscore2 += 1;
                score2.Text = intscore2.ToString();
            }
        }
        private void StartbuttonActions()
        {
            gamepanel.Visible = true;
            gametimer.Enabled = true;
            balltimer.Enabled = true;
            movement_timer.Enabled = true;
        }

        private bool movement_timerup1 = false;
        private bool movement_timerdown1 = false;
        private bool movement_timerup2 = false;
        private bool movement_timerdown2 = false;

        private void movement_timer_Tick(object sender, EventArgs e)
        {
            if (movement_timerup1)
            {
                if(racket1.Top >= topwall.Bottom)
                {
                    racket1.Location = new Point(racket1.Location.X, racket1.Location.Y - 7);
                }
            }
            else if (movement_timerdown1)
            {
                if (racket1.Bottom <= bottomwall.Top)
                {
                    racket1.Location = new Point(racket1.Location.X, racket1.Location.Y + 7);
                }
            }
            else if (movement_timerup2)
            {
                if(racket2.Top >= topwall.Bottom) 
                { 
                    racket2.Location = new Point(racket2.Location.X, racket2.Location.Y - 7);
                }
            }
            else if (movement_timerdown2)
            {
                if(racket2.Bottom <= bottomwall.Top)
                {
                    racket2.Location = new Point(racket2.Location.X, racket2.Location.Y + 7);
                }
            }
        }

        private void StartScreen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                movement_timerup1 = true;
            }
            else if (e.KeyCode == Keys.S)
            {
                movement_timerdown1 = true;
            }
            else if (e.KeyCode == Keys.K)
            {
                movement_timerup2 = true;
            }
            else if (e.KeyCode == Keys.L)
            {
                movement_timerdown2 = true;
            }
        }

        private void StartScreen_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                movement_timerup1 = false;
            }
            else if (e.KeyCode == Keys.S)
            {
                movement_timerdown1 = false;
            }
            else if (e.KeyCode == Keys.K)
            {
                movement_timerup2 = false;
            }
            else if (e.KeyCode == Keys.L)
            {
                movement_timerdown2 = false;
            }
        }
    }
}
