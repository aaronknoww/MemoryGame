using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemeryGame.Logic
{
    internal class Card : PictureBox
    {
        private Bitmap front;
        private Bitmap back = Properties.Resources.Girada;
            
        public Card()
        {
            
            this.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Size = new System.Drawing.Size(100, 100);
            this.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TabStop = false;
            //this.Image = Properties.Resources.Girada;
            this.Image = back;
            this.Cursor = Cursors.Hand;
            this.Name = "pictureBox";
            this.Click +=  voltear;
            

        }
        public Card(Bitmap front): this()
        {
            this.front = front;
         
        }
        public void voltear(object sender, EventArgs e)
        {
            this.Image = front;
        }

            
    }

    //private void ChkBoton_CheckedChanged(object? sender, EventArgs e)
    //{

    //    Control ctr = this.Parent; // Se obtine el contenedor padre de boton precionado.
    //    Tablero tablero = (Tablero)ctr; //Se castea para saber si es un tablero.  
    //    int numeroFila = tablero.GetRow(this);

    //    if (this.Checked == true)
    //        ISorteo.BuscarNumeros(tablero, numeroFila);
    //    else
    //        ISorteo.RestaurarNumeros(tablero, numeroFila);




    //}


}
