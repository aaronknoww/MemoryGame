using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemeryGame.Logic
{
    internal class Card : PictureBox, IComparable<Card>, IComparer<Card>
    {
        private readonly Bitmap _front;
        private readonly Bitmap back = Properties.Resources.Girada;
        private int    _id;
        Game _game;
        
        public Card()
        {
            _id= 0;
            this.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Size = new System.Drawing.Size(100, 100);
            this.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TabStop = false;
            this.Image = back;
            this.Cursor = Cursors.Hand;
            this.Name = "pictureBox";
            this.Click +=  flipCard;
            

        }
        public Card(int id, Bitmap front): this()
        {
            this._id = id;  
            this._front = front;
         
        }
        public Card(int id, Bitmap front, Game game) : this() 
        {
            this._id = id;
            this._front = front;
            this._game = game;

        }
        public void flipCard(object sender, EventArgs e)
        {
            this.Image = _front;
           
            if (_game == null)
                return;
            if(_game.checkPair(this)==3)
            {
                Control ctr = this.Parent.Parent; // Se obtiene el contenedor padre de boton precionado.
                Panel panel  = (Panel)ctr;
                panel.Enabled = false;
                panel.Enabled = true;
                panel.Enabled = false;
                return;
            }
            Control ctrl = this.Parent.Parent.Parent;
            Form form = (Form)ctrl;
            var c = form.Controls;
            int index = c.IndexOfKey("lblMove"); //Se obtiene el indice del elemento que tenga esa clave.
            c[index].Enabled = false;
            c[index].Enabled = true;
        }
       

        public int  getId()
        {
            return _id;
        }
        public int  CompareTo(Card other)
        {
            if (other == null)                              
                throw new NullReferenceException();
            if (this._id == other._id && this._front == other._front)
                return 0;
            if (this._id > other._id)
                return 1;
            return -1;
               
        }
        public int  Compare(Card x, Card y)
        {
            if (x == null || y == null)
                throw new NullReferenceException();

            return x.CompareTo(y);             
            

        }
    }

}
