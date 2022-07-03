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
            this.lblSetPair.Text = game.PairRemain.ToString();
            pnlFather.Controls.Add(game.Board);
        }

        private void tmrShowCard_Tick(object sender, EventArgs e)
        {
            game.coverBoth();
            tmrShowCard.Stop();
            pnlFather.Enabled = true;
        }

        private void pnlFather_EnabledChanged(object sender, EventArgs e)
        {
            if (pnlFather.Enabled)
                return;
            tmrShowCard.Start();
        }
    }
}
