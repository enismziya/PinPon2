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
        public StartScreen()
        {
            InitializeComponent();
        }

        private void btn_playervsplayer_Click(object sender, EventArgs e)
        {
            gamemode = 1;
            gamepanel.Visible = true;
            player2name_txt.Text = "Player2";
        }

        private void btn_playervsai_Click(object sender, EventArgs e)
        {
            gamemode = 0;
            gamepanel.Visible = true;
            player2name_txt.Text = "Computer";
        }

        private void menubtn_Click(object sender, EventArgs e)
        {
            gamepanel.Visible = false;
        }
    }
}
