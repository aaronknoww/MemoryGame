namespace MemeryGame.View
{
    partial class EasyForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EasyForm));
            this.pnlFather = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // pnlFather
            // 
            this.pnlFather.Location = new System.Drawing.Point(284, 76);
            this.pnlFather.Name = "pnlFather";
            this.pnlFather.Size = new System.Drawing.Size(600, 600);
            this.pnlFather.TabIndex = 1;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "img3.jpg");
            this.imageList1.Images.SetKeyName(1, "img4.jpg");
            this.imageList1.Images.SetKeyName(2, "img5.jpg");
            this.imageList1.Images.SetKeyName(3, "img6.jpg");
            this.imageList1.Images.SetKeyName(4, "img7.jpg");
            this.imageList1.Images.SetKeyName(5, "img8.jpg");
            this.imageList1.Images.SetKeyName(6, "img9.jpg");
            this.imageList1.Images.SetKeyName(7, "img10.jpg");
            this.imageList1.Images.SetKeyName(8, "img11.jpg");
            // 
            // EasyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1207, 688);
            this.Controls.Add(this.pnlFather);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EasyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EasyForm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlFather;
        private System.Windows.Forms.ImageList imageList1;
    }
}