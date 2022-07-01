using MemeryGame.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemeryGame
{
    public partial class Main : Form
    {
        private Form formaActiva;
        public Main()
        {
            InitializeComponent();
        }

        private void pbEasy_Click(object sender, EventArgs e)
        {
            EasyForm easy= new EasyForm();
          // easy.Show();
            loadForm(easy);

        }

        private void pbMedium_Click(object sender, EventArgs e)
        {

        }

        private void pbDificil_Click(object sender, EventArgs e)
        {

        }
        private void loadForm(Form hija)
        {

            if (formaActiva != null)
            {
                formaActiva.Close();
            }
            //Activate();
            formaActiva = hija;

            //// Configuracion de la forma hija, para que se adapte al panel del menupricipal. 

            formaActiva.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None; //----> Para quitar los bordes y los botones de control de ventana.
            formaActiva.TopLevel = false;
            formaActiva.Dock = DockStyle.Fill;
            this.pnlPrincipal.Controls.Add(formaActiva); // --------> Se agrega la forma al panel de control.
            this.pnlPrincipal.Tag = formaActiva;
            formaActiva.BringToFront();
            formaActiva.Show();
        }
    }
}
