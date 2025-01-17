namespace PinPon2
{
    partial class StartScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartScreen));
            this.label1 = new System.Windows.Forms.Label();
            this.title_txt = new System.Windows.Forms.Label();
            this.gamepanel = new System.Windows.Forms.Panel();
            this.player1name_txt = new System.Windows.Forms.Label();
            this.player2name_txt = new System.Windows.Forms.Label();
            this.timer_txt = new System.Windows.Forms.Label();
            this.score2 = new System.Windows.Forms.Label();
            this.score1 = new System.Windows.Forms.Label();
            this.score_txt2 = new System.Windows.Forms.Label();
            this.score_txt1 = new System.Windows.Forms.Label();
            this.menubtn = new System.Windows.Forms.Button();
            this.racket1 = new System.Windows.Forms.PictureBox();
            this.racket2 = new System.Windows.Forms.PictureBox();
            this.bottomwall = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.topwall = new System.Windows.Forms.PictureBox();
            this.btn_playervsplayer = new System.Windows.Forms.Button();
            this.btn_playervsai = new System.Windows.Forms.Button();
            this.gametimer = new System.Windows.Forms.Timer(this.components);
            this.balltimer = new System.Windows.Forms.Timer(this.components);
            this.movement_timer = new System.Windows.Forms.Timer(this.components);
            this.gamepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.racket1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racket2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomwall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topwall)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // title_txt
            // 
            this.title_txt.Font = new System.Drawing.Font("Brush Script MT", 105F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_txt.ForeColor = System.Drawing.Color.White;
            this.title_txt.Location = new System.Drawing.Point(250, 60);
            this.title_txt.Name = "title_txt";
            this.title_txt.Size = new System.Drawing.Size(500, 150);
            this.title_txt.TabIndex = 1;
            this.title_txt.Text = "PinPon2";
            // 
            // gamepanel
            // 
            this.gamepanel.Controls.Add(this.player1name_txt);
            this.gamepanel.Controls.Add(this.player2name_txt);
            this.gamepanel.Controls.Add(this.timer_txt);
            this.gamepanel.Controls.Add(this.score2);
            this.gamepanel.Controls.Add(this.score1);
            this.gamepanel.Controls.Add(this.score_txt2);
            this.gamepanel.Controls.Add(this.score_txt1);
            this.gamepanel.Controls.Add(this.menubtn);
            this.gamepanel.Controls.Add(this.racket1);
            this.gamepanel.Controls.Add(this.racket2);
            this.gamepanel.Controls.Add(this.bottomwall);
            this.gamepanel.Controls.Add(this.ball);
            this.gamepanel.Controls.Add(this.topwall);
            this.gamepanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gamepanel.Location = new System.Drawing.Point(0, 0);
            this.gamepanel.Name = "gamepanel";
            this.gamepanel.Size = new System.Drawing.Size(984, 461);
            this.gamepanel.TabIndex = 4;
            this.gamepanel.Visible = false;
            // 
            // player1name_txt
            // 
            this.player1name_txt.BackColor = System.Drawing.Color.Firebrick;
            this.player1name_txt.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1name_txt.ForeColor = System.Drawing.Color.White;
            this.player1name_txt.Location = new System.Drawing.Point(15, 15);
            this.player1name_txt.Name = "player1name_txt";
            this.player1name_txt.Size = new System.Drawing.Size(80, 20);
            this.player1name_txt.TabIndex = 12;
            this.player1name_txt.Text = "Player1";
            // 
            // player2name_txt
            // 
            this.player2name_txt.BackColor = System.Drawing.Color.Firebrick;
            this.player2name_txt.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2name_txt.ForeColor = System.Drawing.Color.White;
            this.player2name_txt.Location = new System.Drawing.Point(860, 15);
            this.player2name_txt.Name = "player2name_txt";
            this.player2name_txt.Size = new System.Drawing.Size(100, 20);
            this.player2name_txt.TabIndex = 11;
            this.player2name_txt.Text = "Computer";
            // 
            // timer_txt
            // 
            this.timer_txt.BackColor = System.Drawing.Color.Transparent;
            this.timer_txt.Font = new System.Drawing.Font("Showcard Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer_txt.ForeColor = System.Drawing.Color.White;
            this.timer_txt.Location = new System.Drawing.Point(465, 55);
            this.timer_txt.Name = "timer_txt";
            this.timer_txt.Size = new System.Drawing.Size(60, 30);
            this.timer_txt.TabIndex = 10;
            this.timer_txt.Text = "120";
            // 
            // score2
            // 
            this.score2.BackColor = System.Drawing.Color.Transparent;
            this.score2.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score2.ForeColor = System.Drawing.Color.White;
            this.score2.Location = new System.Drawing.Point(925, 60);
            this.score2.Name = "score2";
            this.score2.Size = new System.Drawing.Size(30, 20);
            this.score2.TabIndex = 9;
            this.score2.Text = "0";
            // 
            // score1
            // 
            this.score1.BackColor = System.Drawing.Color.Transparent;
            this.score1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score1.ForeColor = System.Drawing.Color.White;
            this.score1.Location = new System.Drawing.Point(80, 60);
            this.score1.Name = "score1";
            this.score1.Size = new System.Drawing.Size(30, 20);
            this.score1.TabIndex = 8;
            this.score1.Text = "0";
            // 
            // score_txt2
            // 
            this.score_txt2.BackColor = System.Drawing.Color.Transparent;
            this.score_txt2.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_txt2.ForeColor = System.Drawing.Color.White;
            this.score_txt2.Location = new System.Drawing.Point(860, 60);
            this.score_txt2.Name = "score_txt2";
            this.score_txt2.Size = new System.Drawing.Size(70, 20);
            this.score_txt2.TabIndex = 7;
            this.score_txt2.Text = "Score :";
            // 
            // score_txt1
            // 
            this.score_txt1.BackColor = System.Drawing.Color.Transparent;
            this.score_txt1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_txt1.ForeColor = System.Drawing.Color.White;
            this.score_txt1.Location = new System.Drawing.Point(15, 60);
            this.score_txt1.Name = "score_txt1";
            this.score_txt1.Size = new System.Drawing.Size(70, 20);
            this.score_txt1.TabIndex = 6;
            this.score_txt1.Text = "Score :";
            // 
            // menubtn
            // 
            this.menubtn.BackgroundImage = global::PinPon2.Properties.Resources.home_page;
            this.menubtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menubtn.Location = new System.Drawing.Point(475, 15);
            this.menubtn.Name = "menubtn";
            this.menubtn.Size = new System.Drawing.Size(24, 24);
            this.menubtn.TabIndex = 5;
            this.menubtn.UseVisualStyleBackColor = true;
            this.menubtn.Click += new System.EventHandler(this.menubtn_Click);
            // 
            // racket1
            // 
            this.racket1.BackColor = System.Drawing.Color.White;
            this.racket1.Location = new System.Drawing.Point(15, 180);
            this.racket1.Name = "racket1";
            this.racket1.Size = new System.Drawing.Size(20, 100);
            this.racket1.TabIndex = 4;
            this.racket1.TabStop = false;
            // 
            // racket2
            // 
            this.racket2.BackColor = System.Drawing.Color.White;
            this.racket2.Location = new System.Drawing.Point(950, 180);
            this.racket2.Name = "racket2";
            this.racket2.Size = new System.Drawing.Size(20, 100);
            this.racket2.TabIndex = 3;
            this.racket2.TabStop = false;
            // 
            // bottomwall
            // 
            this.bottomwall.BackColor = System.Drawing.Color.Firebrick;
            this.bottomwall.Location = new System.Drawing.Point(0, 411);
            this.bottomwall.Name = "bottomwall";
            this.bottomwall.Size = new System.Drawing.Size(984, 50);
            this.bottomwall.TabIndex = 2;
            this.bottomwall.TabStop = false;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.OrangeRed;
            this.ball.Location = new System.Drawing.Point(475, 220);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(20, 20);
            this.ball.TabIndex = 1;
            this.ball.TabStop = false;
            // 
            // topwall
            // 
            this.topwall.BackColor = System.Drawing.Color.Firebrick;
            this.topwall.Location = new System.Drawing.Point(0, 0);
            this.topwall.Name = "topwall";
            this.topwall.Size = new System.Drawing.Size(984, 50);
            this.topwall.TabIndex = 0;
            this.topwall.TabStop = false;
            // 
            // btn_playervsplayer
            // 
            this.btn_playervsplayer.BackgroundImage = global::PinPon2.Properties.Resources.playervsplayer;
            this.btn_playervsplayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_playervsplayer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_playervsplayer.Location = new System.Drawing.Point(550, 250);
            this.btn_playervsplayer.Name = "btn_playervsplayer";
            this.btn_playervsplayer.Size = new System.Drawing.Size(120, 120);
            this.btn_playervsplayer.TabIndex = 3;
            this.btn_playervsplayer.UseVisualStyleBackColor = true;
            this.btn_playervsplayer.Click += new System.EventHandler(this.btn_playervsplayer_Click);
            // 
            // btn_playervsai
            // 
            this.btn_playervsai.BackgroundImage = global::PinPon2.Properties.Resources.playervsai;
            this.btn_playervsai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_playervsai.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_playervsai.Location = new System.Drawing.Point(300, 250);
            this.btn_playervsai.Name = "btn_playervsai";
            this.btn_playervsai.Size = new System.Drawing.Size(120, 120);
            this.btn_playervsai.TabIndex = 2;
            this.btn_playervsai.UseVisualStyleBackColor = true;
            this.btn_playervsai.Click += new System.EventHandler(this.btn_playervsai_Click);
            // 
            // gametimer
            // 
            this.gametimer.Interval = 1000;
            this.gametimer.Tick += new System.EventHandler(this.gametimer_Tick);
            // 
            // balltimer
            // 
            this.balltimer.Interval = 10;
            this.balltimer.Tick += new System.EventHandler(this.balltimer_Tick);
            // 
            // movement_timer
            // 
            this.movement_timer.Interval = 20;
            this.movement_timer.Tick += new System.EventHandler(this.movement_timer_Tick);
            // 
            // StartScreen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.gamepanel);
            this.Controls.Add(this.btn_playervsplayer);
            this.Controls.Add(this.btn_playervsai);
            this.Controls.Add(this.title_txt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StartScreen";
            this.Text = "PinPon2";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.StartScreen_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.StartScreen_KeyUp);
            this.gamepanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.racket1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racket2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomwall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topwall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label title_txt;
        private System.Windows.Forms.Button btn_playervsai;
        private System.Windows.Forms.Button btn_playervsplayer;
        private System.Windows.Forms.Panel gamepanel;
        private System.Windows.Forms.Button menubtn;
        private System.Windows.Forms.PictureBox racket1;
        private System.Windows.Forms.PictureBox racket2;
        private System.Windows.Forms.PictureBox bottomwall;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox topwall;
        private System.Windows.Forms.Label score_txt1;
        private System.Windows.Forms.Label score2;
        private System.Windows.Forms.Label score1;
        private System.Windows.Forms.Label score_txt2;
        private System.Windows.Forms.Label timer_txt;
        private System.Windows.Forms.Label player1name_txt;
        private System.Windows.Forms.Label player2name_txt;
        private System.Windows.Forms.Timer gametimer;
        private System.Windows.Forms.Timer balltimer;
        private System.Windows.Forms.Timer movement_timer;
    }
}

