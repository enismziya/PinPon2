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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartScreen));
            this.label1 = new System.Windows.Forms.Label();
            this.title_txt = new System.Windows.Forms.Label();
            this.btn_playervsai = new System.Windows.Forms.Button();
            this.btn_playervsplayer = new System.Windows.Forms.Button();
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
            // 
            // StartScreen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.btn_playervsplayer);
            this.Controls.Add(this.btn_playervsai);
            this.Controls.Add(this.title_txt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StartScreen";
            this.Text = "PinPon2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label title_txt;
        private System.Windows.Forms.Button btn_playervsai;
        private System.Windows.Forms.Button btn_playervsplayer;
    }
}

