using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PinPon2
{
    public partial class StartScreen : Form
    {
        //gamemode 1 = player vs player, gamemode 2 = player vs ai
        private int gamemode;
        public int gametime = 120;
        public int ball_speedx = 3, ball_speedy = 3;
        public int intscore1 = 0, intscore2 = 0;
        public StartScreen()
        {
            InitializeComponent();
            this.KeyPreview = true;
            timer_txt.Text = gametime.ToString();
        }
        private void StartScreen_Load(object sender, EventArgs e)
        {
            pausepanel.BackColor = Color.Transparent;
        }
        private void btn_playervsplayer_Click(object sender, EventArgs e)
        {
            gamemode = 1;
            player2name_txt.Text = "Player2";
            gamepanel.Visible = true;
            StartActions();
        }

        private void btn_playervsai_Click(object sender, EventArgs e)
        {
            gamemode = 0;
            player2name_txt.Text = "Computer";
            gamepanel.Visible = true;
            StartActions();
        }
        private void pausebtn_Click(object sender, EventArgs e)
        {
            pausepanel.Visible = true;
            PauseActions();
        }
        private void menubtn_Click(object sender, EventArgs e)
        {
            MenuActions();
        }
        private void restartbtn_Click(object sender, EventArgs e)
        {
            RestartActions();
        }

        private void pausepanel_playbtn_Click(object sender, EventArgs e)
        {
            pausepanel.Visible = false;
            StartActions();
        }

        private void pausepanel_menubtn_Click(object sender, EventArgs e)
        {
            MenuActions();
        }

        private void pausepanel_restartbtn_Click(object sender, EventArgs e)
        {
            pausepanel.Visible = false;
            RestartActions();
            StartActions();

        }
        private void winner_menubtn_Click(object sender, EventArgs e)
        {
            winner_panel.Visible = false;
            MenuActions();
        }

        private void winner_restartbtn_Click(object sender, EventArgs e)
        {
            winner_panel.Visible = false;
            RestartActions();
            StartActions();
        }

        private void StartActions()
        {
            gametimer.Enabled = true;
            balltimer.Enabled = true;
            movement_timer.Enabled = true;
        }

        private void RestartActions()
        {
            gametime = 120;
            timer_txt.Text = gametime.ToString();
            ball.Location = new Point(475, 220);
            ball_speedx = 1;
            racket1.Location = new Point(15, 180);
            racket2.Location = new Point(950, 180);
            intscore1 = 0;
            intscore2 = 0;
            score1.Text = intscore1.ToString();
            score2.Text = intscore2.ToString(); 
        }

        private void PauseActions()
        {

            gametimer.Enabled = false;
            balltimer.Enabled = false;
            movement_timer.Enabled = false;
        }
        private void MenuActions()
        {
            gamepanel.Visible = false;
            pausepanel.Visible = false;
            gametimer.Enabled = false;
            balltimer.Enabled = false;
            movement_timer.Enabled = false;
            RestartActions();
        }

        private void gametimer_Tick(object sender, EventArgs e)
        {
            if (gametime >= 0)
            {
                timer_txt.Text = gametime.ToString();
                gametime -= 1;
            }
            else 
            {
                if (intscore1 > intscore2)
                {
                    winner_txt.Text = player1name_txt.Text + "\nWIN!!!";
                    winner_panel.Visible = true;
                    PauseActions();
                }
                else if (intscore1 < intscore2)
                {
                    winner_txt.Text = player2name_txt.Text + "\nWIN!!!";
                    winner_panel.Visible = true;
                    PauseActions();
                }
                else 
                {
                    winner_txt.Text = "DRAW!!!";
                    winner_panel.Visible = true;
                    PauseActions();
                }
            }
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
            else if (ball.Left <= racket1.Right && ball.Left >= racket1.Left && ball.Top >= racket1.Top && ball.Bottom <= racket1.Bottom)
            {
                ball_speedx = -ball_speedx;
            }
            else if (ball.Right >= racket2.Left && ball.Right <= racket2.Right && ball.Top >= racket2.Top && ball.Bottom <= racket2.Bottom)
            {
                ball_speedx = -ball_speedx;
            }

            else if (ball.Right >= gamepanel.Right + 10)
            {
                ball.Location = new Point(475, 220);
                ball_speedx = 3;
                intscore1 += 1;
                score1.Text = intscore1.ToString();
            }
            else if (ball.Left <= gamepanel.Left - 10)
            {
                ball.Location = new Point(475, 220);
                ball_speedx = -3;
                intscore2 += 1;
                score2.Text = intscore2.ToString();
            }
        }

        private HashSet<Keys> pressedkeys = new HashSet<Keys>();

        private void movement_timer_Tick(object sender, EventArgs e)
        {
            if (pressedkeys.Contains(Keys.A) && racket1.Top >= topwall.Bottom)
            {
                racket1.Location = new Point(racket1.Location.X, racket1.Location.Y - 3);
            }
            if (pressedkeys.Contains(Keys.S) && racket1.Bottom <= bottomwall.Top)
            {
                racket1.Location = new Point(racket1.Location.X, racket1.Location.Y + 3);
            }
            if (pressedkeys.Contains(Keys.K) && racket2.Top >= topwall.Bottom)
            {
                racket2.Location = new Point(racket2.Location.X, racket2.Location.Y - 3);
            }
            if (pressedkeys.Contains(Keys.L) && racket2.Bottom <= bottomwall.Top)
            {
                racket2.Location = new Point(racket2.Location.X, racket2.Location.Y + 3);
            }
        }



        private void StartScreen_KeyDown(object sender, KeyEventArgs e)
        {
            if (!pressedkeys.Contains(e.KeyCode))
            {
                pressedkeys.Add(e.KeyCode);
            }
        }

        private void StartScreen_KeyUp(object sender, KeyEventArgs e)
        {
            if (pressedkeys.Contains(e.KeyCode))
            {
                pressedkeys.Remove(e.KeyCode);
            }
        }
    }
}
