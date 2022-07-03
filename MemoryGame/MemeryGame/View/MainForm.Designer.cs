namespace MemeryGame
{
    partial class Main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label lblTitle;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFacil = new System.Windows.Forms.Label();
            this.pbDificil = new System.Windows.Forms.PictureBox();
            this.pbMedium = new System.Windows.Forms.PictureBox();
            this.pbEasy = new System.Windows.Forms.PictureBox();
            this.tmShowCard = new System.Windows.Forms.Timer(this.components);
            lblTitle = new System.Windows.Forms.Label();
            this.pnlPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDificil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMedium)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEasy)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitle.ForeColor = System.Drawing.Color.Black;
            lblTitle.Location = new System.Drawing.Point(371, 44);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(504, 69);
            lblTitle.TabIndex = 10;
            lblTitle.Text = "MEMORY GAME";
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.Transparent;
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(1382, 70);
            this.pnlTitulo.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(155, 738);
            this.panel1.TabIndex = 2;
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.pnlPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlPrincipal.Controls.Add(lblTitle);
            this.pnlPrincipal.Controls.Add(this.label5);
            this.pnlPrincipal.Controls.Add(this.label4);
            this.pnlPrincipal.Controls.Add(this.label3);
            this.pnlPrincipal.Controls.Add(this.label2);
            this.pnlPrincipal.Controls.Add(this.label1);
            this.pnlPrincipal.Controls.Add(this.lblFacil);
            this.pnlPrincipal.Controls.Add(this.pbDificil);
            this.pnlPrincipal.Controls.Add(this.pbMedium);
            this.pnlPrincipal.Controls.Add(this.pbEasy);
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlPrincipal.Location = new System.Drawing.Point(155, 70);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(1227, 738);
            this.pnlPrincipal.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(880, 473);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 38);
            this.label5.TabIndex = 9;
            this.label5.Text = "Size 5x6";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(540, 473);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 38);
            this.label4.TabIndex = 8;
            this.label4.Text = "Size 4x6";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(186, 473);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 38);
            this.label3.TabIndex = 7;
            this.label3.Text = "Size 4x4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(857, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 38);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hard Level";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(505, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "Medium Level";
            // 
            // lblFacil
            // 
            this.lblFacil.AutoSize = true;
            this.lblFacil.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacil.Location = new System.Drawing.Point(170, 230);
            this.lblFacil.Name = "lblFacil";
            this.lblFacil.Size = new System.Drawing.Size(188, 38);
            this.lblFacil.TabIndex = 4;
            this.lblFacil.Text = "Easy Level";
            // 
            // pbDificil
            // 
            this.pbDificil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbDificil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbDificil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbDificil.Image = ((System.Drawing.Image)(resources.GetObject("pbDificil.Image")));
            this.pbDificil.Location = new System.Drawing.Point(853, 269);
            this.pbDificil.Name = "pbDificil";
            this.pbDificil.Size = new System.Drawing.Size(200, 185);
            this.pbDificil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDificil.TabIndex = 3;
            this.pbDificil.TabStop = false;
            this.pbDificil.Click += new System.EventHandler(this.pbDificil_Click);
            // 
            // pbMedium
            // 
            this.pbMedium.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbMedium.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMedium.Image = ((System.Drawing.Image)(resources.GetObject("pbMedium.Image")));
            this.pbMedium.Location = new System.Drawing.Point(524, 269);
            this.pbMedium.Name = "pbMedium";
            this.pbMedium.Size = new System.Drawing.Size(200, 185);
            this.pbMedium.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMedium.TabIndex = 2;
            this.pbMedium.TabStop = false;
            this.pbMedium.Click += new System.EventHandler(this.pbMedium_Click);
            // 
            // pbEasy
            // 
            this.pbEasy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbEasy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbEasy.Image = ((System.Drawing.Image)(resources.GetObject("pbEasy.Image")));
            this.pbEasy.Location = new System.Drawing.Point(165, 269);
            this.pbEasy.Name = "pbEasy";
            this.pbEasy.Size = new System.Drawing.Size(200, 185);
            this.pbEasy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEasy.TabIndex = 1;
            this.pbEasy.TabStop = false;
            this.pbEasy.Click += new System.EventHandler(this.pbEasy_Click);
            // 
            // tmShowCard
            // 
            this.tmShowCard.Interval = 500;
            this.tmShowCard.Tick += new System.EventHandler(this.tmShowCard_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1382, 808);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTitulo);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memory Game";
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDificil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMedium)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEasy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.PictureBox pbDificil;
        private System.Windows.Forms.PictureBox pbMedium;
        private System.Windows.Forms.PictureBox pbEasy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFacil;
        public  System.Windows.Forms.Timer tmShowCard;
    }
}

