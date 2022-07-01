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
        Board board;
        public EasyForm()
        {
            InitializeComponent();
            board = new Board(4,4);
            pnlFather.Controls.Add(board);
        }
    }
}
