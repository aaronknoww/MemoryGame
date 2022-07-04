using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemeryGame.Logic
{
    internal class Game 
    {
        private int        moveCounter;
        private int        pairRemain;
        private Board      board;
        private int        _rows;
        private int        _columns;
        private Card       card1;
        private Card       card2;
        private byte       cardFlip;
        private short      seconds;
        

        public Game(int rows, int columns)
        {
            Seconds = 60;
            cardFlip = 0;
            moveCounter = 0;
            pairRemain = (rows * columns) / 2;
            this._rows = rows;
            this._columns = columns;
            board = new Board(_rows, _columns, this);
           
        }
        public byte checkPair(Card card)
        {
            // Return 1  when the first card flipped.
            // Return 2  when both cards are equal.
            // Return 3  when both cards are different.
            // Return 99 when error ocurrs.

            if (card == null) return 99;

            if(cardFlip==0)
            {
                card1 = card;
                card.Enabled = false;
                cardFlip = 1;
                return 1;
            }
            card2 = card;
            
            if(card1.CompareTo(card2)==0)
            {
                card.Enabled = false;
                moveCounter++;
                pairRemain--;

                cardFlip = 0;
                card1 = null;
                card2 = null;
                return 2;
            }
            else 
            {
                moveCounter++;
                cardFlip = 2;
                return 3;
                             
            }

            
        }
        public void coverBoth()
        {
            card1.Enabled = true;
            card2.Enabled = true;
            card1.Image = Properties.Resources.Girada;
            card2.Image = Properties.Resources.Girada;
            cardFlip = 0;
            card1 = null;
            card2 = null;
        }
        
        public void restartGame() 
        {
            board.Dispose();
            board = null;
            card1 = null;
            card2 = null;           
            Seconds = 60;
            cardFlip = 0;
            moveCounter = 0;
            pairRemain = (_rows * _columns) / 2;                       
            board = new Board(_rows, _columns, this);
        }
        public Board Board { get { return board; } }
        public int MoveCounter { get => moveCounter; set => moveCounter = value; }
        public int PairRemain { get => pairRemain; set => pairRemain = value; }
        public short Seconds { get => seconds; set => seconds = value; }
    }
}
