using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemeryGame.Logic
{
    internal class Board : TableLayoutPanel
    {
        private DeckMaker deck;
        public Board()
        {
            this.RowCount = 2;
            this.ColumnCount = 2;
            this.Name = "tlpBoard";
            this.Dock = DockStyle.Fill;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Size = new System.Drawing.Size(100, 100);
            this.TabIndex = 2;

        }
        public Board(int Filas, int Columnas) : this()
        {
            this.RowCount = Filas;
            this.ColumnCount = Columnas;
            deck = new DeckMaker((Filas * Columnas) / 2);
            
            List<Card> cards = deck.getDeck();

            for (int i = 0; i < Filas; i++)
                this.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25f));
            for (int i = 0; i < Columnas; i++)
                this.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25f));

            cards.ForEach(card => this.Controls.Add(card));
            
        }
        public Board(int  Filas , int Columnas, Game game) : this()
        {
            this.RowCount = Filas;
            this.ColumnCount = Columnas;
            deck = new DeckMaker((Filas * Columnas) / 2, game);

            List<Card> cards = deck.getDeck();

            for (int i = 0; i < Filas; i++)
                this.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25f));
            for (int i = 0; i < Columnas; i++)
                this.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25f));

            cards.ForEach(card => this.Controls.Add(card));
        }
                
    }
}
