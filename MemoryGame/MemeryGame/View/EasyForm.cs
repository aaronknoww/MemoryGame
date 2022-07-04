using MemeryGame.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemeryGame.View
{
    public partial class EasyForm : Form
    {
        
        Game game;
        public EasyForm()
        {
            InitializeComponent();

            game = new Game(4, 4);
            pnlFather.Controls.Add(game.Board);
            lblSetPair.Text = game.PairRemain.ToString();
            lblSetCount.Text = game.MoveCounter.ToString();
            tmrSeconds.Start();
        }

        private void tmrShowCard_Tick(object sender, EventArgs e)
        {
            
            game.coverBoth();
            tmrShowCard.Stop();
            pnlFather.Enabled = true;
            btbRestart.Enabled = true;
        }

        private void pnlFather_EnabledChanged(object sender, EventArgs e)
        {
            btbRestart.Enabled = false;
            if (pnlFather.Enabled)
                return;
            tmrShowCard.Start();
        }

        private void tmrSeconds_Tick(object sender, EventArgs e)
        {
            game.Seconds--;
            lblSetTime.Text = game.Seconds.ToString()+" seconds";
            if (game.Seconds <= 0)
            {
                tmrSeconds.Stop();
                MessageBox.Show("Yo lose","Time up",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
        }

        private void lblMove_EnabledChanged(object sender, EventArgs e)
        {
            lblSetPair.Text = game.PairRemain.ToString();
            lblSetCount.Text = game.MoveCounter.ToString();
            if(game.PairRemain <= 0)
            {
                tmrSeconds.Stop();
                tmrShowCard.Stop();
                MessageBox.Show("You win", "Game over", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btbRestart_Click(object sender, EventArgs e)
        {
            game.restartGame();
            pnlFather.Controls.Clear();
            pnlFather.Controls.Add(game.Board);
            lblSetPair.Text = game.PairRemain.ToString();
            lblSetCount.Text = game.MoveCounter.ToString();
            tmrSeconds.Start();

        }
    }
}
