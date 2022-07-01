using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace MemeryGame.Logic
{
    internal class Deck 
    {
        private List<Card> deck;   
        public Deck(int totalPairs) 
        {
            deck = new List<Card>(totalPairs * 2);

            //ImageList imageList1 = new ImageList();
            //imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            //imageList1.TransparentColor = System.Drawing.Color.Transparent;
            //imageList1.Images.SetKeyName(0, "img3.jpg");
            //imageList1.Images.SetKeyName(1, "img4.jpg");
            //imageList1.Images.SetKeyName(2, "img5.jpg");
            //imageList1.Images.SetKeyName(3, "img6.jpg");
            //imageList1.Images.SetKeyName(4, "img7.jpg");
            //imageList1.Images.SetKeyName(5, "img8.jpg");
            //imageList1.Images.SetKeyName(6, "img9.jpg");
            //imageList1.Images.SetKeyName(7, "img10.jpg");
            //imageList1.Images.SetKeyName(8, "img11.jpg");

            //deck.ForEach( el => el = new Card());
            for (int i = 0; i < deck.Capacity; i++)
            {
                
               Bitmap front = (Bitmap)Properties.Resources.ResourceManager.GetObject("img" + i);
                deck.Add(new Card(front));
            }
                
        }
        public List<Card> getDeck()
        {
            return deck;
        }
    }
}
