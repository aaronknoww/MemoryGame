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
        private Deck deck;
        public Board()
        {
            this.RowCount = 2;
            this.ColumnCount = 2;
            this.Name = "tlpBoard";
            //this.Location = new System.Drawing.Point(50, 85);
            this.Dock = DockStyle.Fill;

            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            //this.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            //this.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
            //this.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
                       
            this.Size = new System.Drawing.Size(100, 100);
            this.TabIndex = 2;

        }
        public Board(byte Filas, byte Columnas) : this()
        {
            this.RowCount = Filas;
            this.ColumnCount = Columnas;
            deck = new Deck((Filas * Columnas) / 2);
            List<Card> cards = deck.getDeck();

            for (int i = 0; i < Filas; i++)
            {
                this.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25f));
                this.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25f));
            }

            cards.ForEach(card => this.Controls.Add(card));
            
        }
                
    }
}
