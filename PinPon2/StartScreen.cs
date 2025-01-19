using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace PinPon2
{
    public partial class StartScreen : Form
    {
        //gamemode 1 = player vs player, gamemode 2 = player vs ai
        private int gamemode;
        public int gametime;
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
            optianspanel_actions();
        }

        private void btn_playervsai_Click(object sender, EventArgs e)
        {
            gamemode = 0;
            optianspanel_actions();
        }
        private void timer30btn_Click(object sender, EventArgs e)
        {
            timercount.Text = "30";
        }

        private void timer60btn_Click(object sender, EventArgs e)
        {
            timercount.Text = "60";
        }

        private void timer120btn_Click(object sender, EventArgs e)
        {
            timercount.Text = "120";
        }

        private Label p1label = new Label();
        private Label p2label = new Label();
        private Label difficulty = new Label();
        private Button middif = new Button();
        private Button harddiff = new Button();
        private TextBox p1textbox = new TextBox();
        private TextBox p2textbox = new TextBox();
        private Font textfonts = new Font("Gill Sans Ultra Bold", 16);
        private void optianspanel_actions()
        {
            if (gamemode == 1)
            {
                startpanel.Visible = true;
                startpanel.Controls.Add(p1label);
                p1label.Text = "Player1 Name";
                p1label.Font = textfonts;
                p1label.Location = new Point(230, 140);
                p1label.ForeColor = Color.White;
                p1label.AutoSize = true;
                startpanel.Controls.Add(p2label);
                p2label.Text = "Player2 Name";
                p2label.Font = textfonts;
                p2label.Location = new Point(565, 140);
                p2label.ForeColor = Color.White;
                p2label.AutoSize = true;
                startpanel.Controls.Add(p1textbox);
                p1textbox.Font = textfonts;
                p1textbox.Location = new Point(240, 190);
                p1textbox.MaxLength = 8;
                p1textbox.Size = new Size(180, 32);
                startpanel.Controls.Add(p2textbox);
                p2textbox.Font = textfonts;
                p2textbox.Location = new Point(575, 190);
                p2textbox.MaxLength = 8;
                p2textbox.Size = new Size(180, 32);
            }
            else 
            {
                startpanel.Visible = true;
                startpanel.Controls.Add(p1label);
                p1label.Text = "Player1 Name";
                p1label.Font = textfonts;
                p1label.Location = new Point(230, 140);
                p1label.ForeColor = Color.White;
                p1label.AutoSize = true;
                startpanel.Controls.Add(p1textbox);
                p1textbox.Font = textfonts;
                p1textbox.Location = new Point(240, 190);
                p1textbox.MaxLength = 8;
                p1textbox.Size = new Size(180, 32);
                startpanel.Controls.Add(difficulty);
                difficulty.Text = "Difficulty";
                difficulty.Font = textfonts;
                difficulty.Location = new Point(555, 140);
                difficulty.ForeColor = Color.White;
                difficulty.AutoSize = true;
                startpanel.Controls.Add(middif);
                middif.Font = new Font("Gill Sans Ultra Bold", 12);
                middif.Location = new Point(570, 170);
                middif.ForeColor = Color.White;
                middif.Text = "Medium ✔";
                middif.AutoSize = true;
                middif.Click += middiff_Click;
                startpanel.Controls.Add(harddiff);
                harddiff.Font = new Font("Gill Sans Ultra Bold", 12);
                harddiff.Location = new Point(570, 210);
                harddiff.ForeColor = Color.White;
                harddiff.Text = "Hard";
                harddiff.AutoSize = true;
                harddiff.Click += harddiff_Click;

            }
        }

        private void harddiff_Click(object sender, EventArgs e)
        {
            middif.Text = "Medium";
            harddiff.Text = "Hard ✔";
        }

        private void middiff_Click(object sender, EventArgs e)
        {
            middif.Text = "Medium ✔";
            harddiff.Text = "Hard";
        }
        private void optians_startbtn_Click(object sender, EventArgs e)
        {
            if (gamemode == 1)
            {
                startpanel.Visible = false;
                gamepanel.Visible = true;
                if (string.IsNullOrEmpty(p1textbox.Text)) { player1name_txt.Text = "Player1"; }
                else { player1name_txt.Text = p1textbox.Text; }
                if (string.IsNullOrEmpty(p2textbox.Text)) { player2name_txt.Text = "Player2"; }
                else { player2name_txt.Text = p2textbox.Text; }
                gametime = Int32.Parse(timercount.Text);
                timer_txt.Text = gametime.ToString();
                StartActions();
            }
            else 
            {
                startpanel.Visible = false;
                gamepanel.Visible= true;
                if (string.IsNullOrEmpty(p1textbox.Text)) { player1name_txt.Text = "Player1"; }
                else { player1name_txt.Text = p1textbox.Text; }
                player2name_txt.Text = "Computer";
                gametime = Int32.Parse(timercount.Text);
                timer_txt.Text = gametime.ToString();
                StartActions();
            }
        }

        private void options_menubtn_Click(object sender, EventArgs e)
        {
            startpanel.Visible = false;
            MenuActions();
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
            gametime = Int32.Parse(timercount.Text);
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
            p1textbox.Text = "";
            p2textbox.Text = "";
            timercount.Text = "120";
            player1name_txt.Text = "";
            player2name_txt.Text = "";
            startpanel.Controls.Remove(p1label);
            startpanel.Controls.Remove(p1textbox);
            startpanel.Controls.Remove(p2label);
            startpanel.Controls.Remove(p2textbox);
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
                if (ball_speedx < 0) { ball_speedx -= 2; }
                else { ball_speedx += 2; }
            }
            else if (ball.Top <= topwall.Bottom)
            {
                ball_speedy = -ball_speedy;
                if (ball_speedx < 0) { ball_speedx -= 2; }
                else { ball_speedx += 2; }
            }
            else if (ball.Left <= racket1.Right && ball.Right >= racket1.Left && ball.Bottom >= racket1.Top && ball.Top <= racket1.Bottom)
                {
                ball_speedx = -ball_speedx;
            }
            else if (ball.Right >= racket2.Left && ball.Left <= racket2.Right && ball.Bottom >= racket2.Top && ball.Top <= racket2.Bottom)
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
            if (gamemode == 1)
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
            else
            {
                 if (pressedkeys.Contains(Keys.A) && racket1.Top >= topwall.Bottom)
                {
                    racket1.Location = new Point(racket1.Location.X, racket1.Location.Y - 3);
                }
                if (pressedkeys.Contains(Keys.S) && racket1.Bottom <= bottomwall.Top)
                {
                    racket1.Location = new Point(racket1.Location.X, racket1.Location.Y + 3);
                }
                if(middif.Text == "Medium ✔")
                {
                    if (ball_speedx > 0)
                    {
                        if (ball.Top <= racket2.Top && racket2.Top >= topwall.Bottom)
                        {
                            racket2.Location = new Point(racket2.Location.X, racket2.Location.Y - 3);
                        }
                        else if (ball.Bottom >= racket2.Bottom && racket2.Bottom <= bottomwall.Top)
                        {
                            racket2.Location = new Point(racket2.Location.X, racket2.Location.Y + 3);
                        }
                    }
                }
                else
                {
                    if (ball.Top <= racket2.Top && racket2.Top >= topwall.Bottom + 20)
                    {
                        racket2.Location = new Point(racket2.Location.X, racket2.Location.Y - 3);
                    }
                    else if (ball.Bottom >= racket2.Bottom && racket2.Bottom <= bottomwall.Top - 20)
                    {
                        racket2.Location = new Point(racket2.Location.X, racket2.Location.Y + 3);
                    }
                }


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
