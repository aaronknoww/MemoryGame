using MemeryGame.View;
using System;
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
            loadForm(easy);

        }

        private void pbMedium_Click(object sender, EventArgs e)
        {
            MediumForm medium = new MediumForm();
            loadForm(medium);   
        }

        private void pbDificil_Click(object sender, EventArgs e)
        {
            HardForm hard = new HardForm();
            loadForm(hard);
        }
        private void loadForm(Form hija)
        {

            if (formaActiva != null)
            {
                formaActiva.Close();
            }
            
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

   
        private void btnMenu_Click(object sender, EventArgs e)
        {
            formaActiva?.Close();
        }
    }
}
