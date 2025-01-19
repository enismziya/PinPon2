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
            this.winner_panel = new System.Windows.Forms.Panel();
            this.winner_menubtn = new System.Windows.Forms.Button();
            this.winner_restartbtn = new System.Windows.Forms.Button();
            this.winner_txt = new System.Windows.Forms.Label();
            this.pausepanel = new System.Windows.Forms.Panel();
            this.pausepanel_playbtn = new System.Windows.Forms.Button();
            this.pausepanel_menubtn = new System.Windows.Forms.Button();
            this.pausepanel_restartbtn = new System.Windows.Forms.Button();
            this.paused_txt = new System.Windows.Forms.Label();
            this.restartbtn = new System.Windows.Forms.Button();
            this.pausebtn = new System.Windows.Forms.Button();
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
            this.gametimer = new System.Windows.Forms.Timer(this.components);
            this.balltimer = new System.Windows.Forms.Timer(this.components);
            this.movement_timer = new System.Windows.Forms.Timer(this.components);
            this.btn_playervsplayer = new System.Windows.Forms.Button();
            this.btn_playervsai = new System.Windows.Forms.Button();
            this.startpanel = new System.Windows.Forms.Panel();
            this.timercount = new System.Windows.Forms.Label();
            this.optianstimer_txt = new System.Windows.Forms.Label();
            this.timer60btn = new System.Windows.Forms.Button();
            this.timer120btn = new System.Windows.Forms.Button();
            this.timer30btn = new System.Windows.Forms.Button();
            this.options_menubtn = new System.Windows.Forms.Button();
            this.optians_startbtn = new System.Windows.Forms.Button();
            this.startpanel_title = new System.Windows.Forms.Label();
            this.gamepanel.SuspendLayout();
            this.winner_panel.SuspendLayout();
            this.pausepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.racket1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racket2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomwall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topwall)).BeginInit();
            this.startpanel.SuspendLayout();
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
            this.gamepanel.Controls.Add(this.winner_panel);
            this.gamepanel.Controls.Add(this.pausepanel);
            this.gamepanel.Controls.Add(this.restartbtn);
            this.gamepanel.Controls.Add(this.pausebtn);
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
            // winner_panel
            // 
            this.winner_panel.BackColor = System.Drawing.Color.Transparent;
            this.winner_panel.Controls.Add(this.winner_menubtn);
            this.winner_panel.Controls.Add(this.winner_restartbtn);
            this.winner_panel.Controls.Add(this.winner_txt);
            this.winner_panel.Location = new System.Drawing.Point(300, 55);
            this.winner_panel.Name = "winner_panel";
            this.winner_panel.Size = new System.Drawing.Size(380, 340);
            this.winner_panel.TabIndex = 18;
            this.winner_panel.Visible = false;
            // 
            // winner_menubtn
            // 
            this.winner_menubtn.BackgroundImage = global::PinPon2.Properties.Resources.home_page;
            this.winner_menubtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.winner_menubtn.Location = new System.Drawing.Point(100, 230);
            this.winner_menubtn.Name = "winner_menubtn";
            this.winner_menubtn.Size = new System.Drawing.Size(75, 75);
            this.winner_menubtn.TabIndex = 16;
            this.winner_menubtn.UseVisualStyleBackColor = true;
            this.winner_menubtn.Click += new System.EventHandler(this.winner_menubtn_Click);
            // 
            // winner_restartbtn
            // 
            this.winner_restartbtn.BackgroundImage = global::PinPon2.Properties.Resources.restart;
            this.winner_restartbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.winner_restartbtn.Location = new System.Drawing.Point(200, 230);
            this.winner_restartbtn.Name = "winner_restartbtn";
            this.winner_restartbtn.Size = new System.Drawing.Size(75, 75);
            this.winner_restartbtn.TabIndex = 17;
            this.winner_restartbtn.UseVisualStyleBackColor = true;
            this.winner_restartbtn.Click += new System.EventHandler(this.winner_restartbtn_Click);
            // 
            // winner_txt
            // 
            this.winner_txt.Font = new System.Drawing.Font("Elephant", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winner_txt.ForeColor = System.Drawing.Color.White;
            this.winner_txt.Location = new System.Drawing.Point(0, 2);
            this.winner_txt.Name = "winner_txt";
            this.winner_txt.Size = new System.Drawing.Size(380, 200);
            this.winner_txt.TabIndex = 0;
            this.winner_txt.Text = "COMPUTER WIN!";
            this.winner_txt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pausepanel
            // 
            this.pausepanel.BackColor = System.Drawing.Color.Transparent;
            this.pausepanel.Controls.Add(this.pausepanel_playbtn);
            this.pausepanel.Controls.Add(this.pausepanel_menubtn);
            this.pausepanel.Controls.Add(this.pausepanel_restartbtn);
            this.pausepanel.Controls.Add(this.paused_txt);
            this.pausepanel.Location = new System.Drawing.Point(300, 60);
            this.pausepanel.Name = "pausepanel";
            this.pausepanel.Size = new System.Drawing.Size(380, 330);
            this.pausepanel.TabIndex = 15;
            this.pausepanel.Visible = false;
            // 
            // pausepanel_playbtn
            // 
            this.pausepanel_playbtn.BackgroundImage = global::PinPon2.Properties.Resources.play;
            this.pausepanel_playbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pausepanel_playbtn.Location = new System.Drawing.Point(30, 200);
            this.pausepanel_playbtn.Name = "pausepanel_playbtn";
            this.pausepanel_playbtn.Size = new System.Drawing.Size(75, 75);
            this.pausepanel_playbtn.TabIndex = 16;
            this.pausepanel_playbtn.UseVisualStyleBackColor = true;
            this.pausepanel_playbtn.Click += new System.EventHandler(this.pausepanel_playbtn_Click);
            // 
            // pausepanel_menubtn
            // 
            this.pausepanel_menubtn.BackgroundImage = global::PinPon2.Properties.Resources.home_page;
            this.pausepanel_menubtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pausepanel_menubtn.Location = new System.Drawing.Point(150, 200);
            this.pausepanel_menubtn.Name = "pausepanel_menubtn";
            this.pausepanel_menubtn.Size = new System.Drawing.Size(75, 75);
            this.pausepanel_menubtn.TabIndex = 16;
            this.pausepanel_menubtn.UseVisualStyleBackColor = true;
            this.pausepanel_menubtn.Click += new System.EventHandler(this.pausepanel_menubtn_Click);
            // 
            // pausepanel_restartbtn
            // 
            this.pausepanel_restartbtn.BackgroundImage = global::PinPon2.Properties.Resources.restart;
            this.pausepanel_restartbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pausepanel_restartbtn.Location = new System.Drawing.Point(270, 200);
            this.pausepanel_restartbtn.Name = "pausepanel_restartbtn";
            this.pausepanel_restartbtn.Size = new System.Drawing.Size(75, 75);
            this.pausepanel_restartbtn.TabIndex = 17;
            this.pausepanel_restartbtn.UseVisualStyleBackColor = true;
            this.pausepanel_restartbtn.Click += new System.EventHandler(this.pausepanel_restartbtn_Click);
            // 
            // paused_txt
            // 
            this.paused_txt.Font = new System.Drawing.Font("Elephant", 47.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paused_txt.ForeColor = System.Drawing.Color.White;
            this.paused_txt.Location = new System.Drawing.Point(0, 60);
            this.paused_txt.Name = "paused_txt";
            this.paused_txt.Size = new System.Drawing.Size(380, 80);
            this.paused_txt.TabIndex = 0;
            this.paused_txt.Text = "PAUSED";
            this.paused_txt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // restartbtn
            // 
            this.restartbtn.BackgroundImage = global::PinPon2.Properties.Resources.restart;
            this.restartbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.restartbtn.Location = new System.Drawing.Point(510, 15);
            this.restartbtn.Name = "restartbtn";
            this.restartbtn.Size = new System.Drawing.Size(24, 24);
            this.restartbtn.TabIndex = 14;
            this.restartbtn.UseVisualStyleBackColor = true;
            this.restartbtn.Click += new System.EventHandler(this.restartbtn_Click);
            // 
            // pausebtn
            // 
            this.pausebtn.BackgroundImage = global::PinPon2.Properties.Resources.pause;
            this.pausebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pausebtn.Location = new System.Drawing.Point(440, 15);
            this.pausebtn.Name = "pausebtn";
            this.pausebtn.Size = new System.Drawing.Size(24, 24);
            this.pausebtn.TabIndex = 13;
            this.pausebtn.UseVisualStyleBackColor = true;
            this.pausebtn.Click += new System.EventHandler(this.pausebtn_Click);
            // 
            // player1name_txt
            // 
            this.player1name_txt.BackColor = System.Drawing.Color.Firebrick;
            this.player1name_txt.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1name_txt.ForeColor = System.Drawing.Color.White;
            this.player1name_txt.Location = new System.Drawing.Point(15, 420);
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
            this.player2name_txt.Location = new System.Drawing.Point(860, 420);
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
            this.score2.BackColor = System.Drawing.Color.Firebrick;
            this.score2.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score2.ForeColor = System.Drawing.Color.White;
            this.score2.Location = new System.Drawing.Point(925, 20);
            this.score2.Name = "score2";
            this.score2.Size = new System.Drawing.Size(30, 20);
            this.score2.TabIndex = 9;
            this.score2.Text = "0";
            // 
            // score1
            // 
            this.score1.BackColor = System.Drawing.Color.Firebrick;
            this.score1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score1.ForeColor = System.Drawing.Color.White;
            this.score1.Location = new System.Drawing.Point(80, 20);
            this.score1.Name = "score1";
            this.score1.Size = new System.Drawing.Size(30, 20);
            this.score1.TabIndex = 8;
            this.score1.Text = "0";
            // 
            // score_txt2
            // 
            this.score_txt2.BackColor = System.Drawing.Color.Firebrick;
            this.score_txt2.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_txt2.ForeColor = System.Drawing.Color.White;
            this.score_txt2.Location = new System.Drawing.Point(860, 20);
            this.score_txt2.Name = "score_txt2";
            this.score_txt2.Size = new System.Drawing.Size(70, 20);
            this.score_txt2.TabIndex = 7;
            this.score_txt2.Text = "Score :";
            // 
            // score_txt1
            // 
            this.score_txt1.BackColor = System.Drawing.Color.Firebrick;
            this.score_txt1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_txt1.ForeColor = System.Drawing.Color.White;
            this.score_txt1.Location = new System.Drawing.Point(15, 20);
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
            this.movement_timer.Interval = 10;
            this.movement_timer.Tick += new System.EventHandler(this.movement_timer_Tick);
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
            // startpanel
            // 
            this.startpanel.Controls.Add(this.timercount);
            this.startpanel.Controls.Add(this.optianstimer_txt);
            this.startpanel.Controls.Add(this.timer60btn);
            this.startpanel.Controls.Add(this.timer120btn);
            this.startpanel.Controls.Add(this.timer30btn);
            this.startpanel.Controls.Add(this.options_menubtn);
            this.startpanel.Controls.Add(this.optians_startbtn);
            this.startpanel.Controls.Add(this.startpanel_title);
            this.startpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startpanel.Location = new System.Drawing.Point(0, 0);
            this.startpanel.Name = "startpanel";
            this.startpanel.Size = new System.Drawing.Size(984, 461);
            this.startpanel.TabIndex = 5;
            this.startpanel.Visible = false;
            // 
            // timercount
            // 
            this.timercount.AutoSize = true;
            this.timercount.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timercount.ForeColor = System.Drawing.Color.White;
            this.timercount.Location = new System.Drawing.Point(505, 295);
            this.timercount.Name = "timercount";
            this.timercount.Size = new System.Drawing.Size(67, 30);
            this.timercount.TabIndex = 28;
            this.timercount.Text = "120";
            // 
            // optianstimer_txt
            // 
            this.optianstimer_txt.AutoSize = true;
            this.optianstimer_txt.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optianstimer_txt.ForeColor = System.Drawing.Color.White;
            this.optianstimer_txt.Location = new System.Drawing.Point(495, 260);
            this.optianstimer_txt.Name = "optianstimer_txt";
            this.optianstimer_txt.Size = new System.Drawing.Size(85, 30);
            this.optianstimer_txt.TabIndex = 27;
            this.optianstimer_txt.Text = "Time:";
            // 
            // timer60btn
            // 
            this.timer60btn.Font = new System.Drawing.Font("Engravers MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer60btn.Location = new System.Drawing.Point(415, 285);
            this.timer60btn.Name = "timer60btn";
            this.timer60btn.Size = new System.Drawing.Size(52, 30);
            this.timer60btn.TabIndex = 26;
            this.timer60btn.Text = "60";
            this.timer60btn.UseVisualStyleBackColor = true;
            this.timer60btn.Click += new System.EventHandler(this.timer60btn_Click);
            // 
            // timer120btn
            // 
            this.timer120btn.Font = new System.Drawing.Font("Engravers MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer120btn.Location = new System.Drawing.Point(415, 320);
            this.timer120btn.Name = "timer120btn";
            this.timer120btn.Size = new System.Drawing.Size(52, 30);
            this.timer120btn.TabIndex = 25;
            this.timer120btn.Text = "120";
            this.timer120btn.UseVisualStyleBackColor = true;
            this.timer120btn.Click += new System.EventHandler(this.timer120btn_Click);
            // 
            // timer30btn
            // 
            this.timer30btn.Font = new System.Drawing.Font("Engravers MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer30btn.Location = new System.Drawing.Point(415, 250);
            this.timer30btn.Name = "timer30btn";
            this.timer30btn.Size = new System.Drawing.Size(52, 30);
            this.timer30btn.TabIndex = 22;
            this.timer30btn.Text = "30";
            this.timer30btn.UseVisualStyleBackColor = true;
            this.timer30btn.Click += new System.EventHandler(this.timer30btn_Click);
            // 
            // options_menubtn
            // 
            this.options_menubtn.BackgroundImage = global::PinPon2.Properties.Resources.home_page;
            this.options_menubtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.options_menubtn.Location = new System.Drawing.Point(400, 360);
            this.options_menubtn.Name = "options_menubtn";
            this.options_menubtn.Size = new System.Drawing.Size(75, 75);
            this.options_menubtn.TabIndex = 18;
            this.options_menubtn.UseVisualStyleBackColor = true;
            this.options_menubtn.Click += new System.EventHandler(this.options_menubtn_Click);
            // 
            // optians_startbtn
            // 
            this.optians_startbtn.BackgroundImage = global::PinPon2.Properties.Resources.play;
            this.optians_startbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.optians_startbtn.Location = new System.Drawing.Point(500, 360);
            this.optians_startbtn.Name = "optians_startbtn";
            this.optians_startbtn.Size = new System.Drawing.Size(75, 75);
            this.optians_startbtn.TabIndex = 17;
            this.optians_startbtn.UseVisualStyleBackColor = true;
            this.optians_startbtn.Click += new System.EventHandler(this.optians_startbtn_Click);
            // 
            // startpanel_title
            // 
            this.startpanel_title.AutoSize = true;
            this.startpanel_title.Font = new System.Drawing.Font("Snap ITC", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startpanel_title.ForeColor = System.Drawing.Color.White;
            this.startpanel_title.Location = new System.Drawing.Point(215, 20);
            this.startpanel_title.Name = "startpanel_title";
            this.startpanel_title.Size = new System.Drawing.Size(583, 123);
            this.startpanel_title.TabIndex = 0;
            this.startpanel_title.Text = "OPTIONS";
            // 
            // StartScreen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.startpanel);
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
            this.Load += new System.EventHandler(this.StartScreen_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.StartScreen_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.StartScreen_KeyUp);
            this.gamepanel.ResumeLayout(false);
            this.winner_panel.ResumeLayout(false);
            this.pausepanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.racket1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racket2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomwall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topwall)).EndInit();
            this.startpanel.ResumeLayout(false);
            this.startpanel.PerformLayout();
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
        private System.Windows.Forms.Button pausebtn;
        private System.Windows.Forms.Button restartbtn;
        private System.Windows.Forms.Panel pausepanel;
        private System.Windows.Forms.Label paused_txt;
        private System.Windows.Forms.Button pausepanel_playbtn;
        private System.Windows.Forms.Button pausepanel_menubtn;
        private System.Windows.Forms.Button pausepanel_restartbtn;
        private System.Windows.Forms.Panel winner_panel;
        private System.Windows.Forms.Button winner_menubtn;
        private System.Windows.Forms.Button winner_restartbtn;
        private System.Windows.Forms.Label winner_txt;
        private System.Windows.Forms.Panel startpanel;
        private System.Windows.Forms.Label startpanel_title;
        private System.Windows.Forms.Button options_menubtn;
        private System.Windows.Forms.Button optians_startbtn;
        private System.Windows.Forms.Button timer30btn;
        private System.Windows.Forms.Button timer60btn;
        private System.Windows.Forms.Button timer120btn;
        private System.Windows.Forms.Label timercount;
        private System.Windows.Forms.Label optianstimer_txt;
    }
}

