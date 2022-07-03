using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace MemeryGame.Logic
{
    internal class DeckMaker 
    {
        private List<Card> deck;
        Game _game;
        public DeckMaker(int totalPairs) 
        {
            deck = new List<Card>(totalPairs * 2);

       
            for (int i = 1; i <= deck.Capacity/2; i++)
            {
                
               Bitmap front = (Bitmap)Properties.Resources.ResourceManager.GetObject("img" + i);
                deck.Add(new Card(i, front));
                deck.Add(new Card(i, front));
            }
                
        }
        public DeckMaker(int totalPairs, Game game) 
        {
            this._game = game;
            deck = new List<Card>(totalPairs * 2);


            for (int i = 1; i <= deck.Capacity / 2; i++)
            {

                Bitmap front = (Bitmap)Properties.Resources.ResourceManager.GetObject("img" + i);
                deck.Add(new Card(i, front, game));
                deck.Add(new Card(i, front, game));
            }

        }
        public List<Card> getDeck()
        {

            shuffle();
            return deck; 
        }
        private void shuffle()
        {
            Random random = new Random();
            Card[] temp = new Card[deck.Count];

            int index = 0;
            int totales = 0;
            for (int i = 0; i < deck.Capacity; i++)
            {

                for (int c = 0; c < 4; c++)
                {
                    index = random.Next(0, deck.Count - 1);
                    if (temp[index] == null)
                    {
                        totales++;
                        temp[index] = deck[i];
                        break;
                    }
                    else if (c == 3)
                    {
                        for (int a = 0; a < temp.Length; a++)
                        {
                            if (temp[a] == null)
                            {
                                totales++;
                                temp[a] = deck[i];
                                break;
                            }
                            totales++;
                        }
                    }
                }
            }
            deck = temp.ToList();
        }

    }
}
