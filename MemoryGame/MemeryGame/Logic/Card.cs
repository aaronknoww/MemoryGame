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
        private Bitmap front;
        private Bitmap back = Properties.Resources.Girada;
        private int _id;
            
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
            this.Click +=  voltear;
            

        }
        public Card(int id, Bitmap front): this()
        {
            this._id = id;  
            this.front = front;
         
        }
        public void voltear(object sender, EventArgs e)
        {
            this.Image = front;
        }
        public int getId()
        {
            return _id;
        }

        public int CompareTo(Card other)
        {
            if (other == null)                              
                throw new NullReferenceException();
            if (this._id == other._id && this.front == other.front)
                return 0;
            if (this._id > other._id)
                return 1;
            return -1;
               
        }

        public int Compare(Card x, Card y)
        {
            if (x == null || y == null)
                throw new NullReferenceException();

            return x.CompareTo(y);             
            

        }
    }

}
