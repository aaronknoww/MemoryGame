namespace MemeryGame.View
{
    public partial class EasyForm
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
            this.tmrShowCard = new System.Windows.Forms.Timer(this.components);
            this.lblPair = new System.Windows.Forms.Label();
            this.lblSetPair = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMove = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnlFather
            // 
            this.pnlFather.Location = new System.Drawing.Point(356, 76);
            this.pnlFather.Name = "pnlFather";
            this.pnlFather.Size = new System.Drawing.Size(600, 600);
            this.pnlFather.TabIndex = 1;
            this.pnlFather.EnabledChanged += new System.EventHandler(this.pnlFather_EnabledChanged);
            // 
            // tmrShowCard
            // 
            this.tmrShowCard.Interval = 1000;
            this.tmrShowCard.Tick += new System.EventHandler(this.tmrShowCard_Tick);
            // 
            // lblPair
            // 
            this.lblPair.AutoSize = true;
            this.lblPair.BackColor = System.Drawing.Color.Transparent;
            this.lblPair.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPair.ForeColor = System.Drawing.Color.Tomato;
            this.lblPair.Location = new System.Drawing.Point(12, 117);
            this.lblPair.Name = "lblPair";
            this.lblPair.Size = new System.Drawing.Size(235, 32);
            this.lblPair.TabIndex = 2;
            this.lblPair.Text = "Remaining pairs";
            // 
            // lblSetPair
            // 
            this.lblSetPair.AutoSize = true;
            this.lblSetPair.BackColor = System.Drawing.Color.Transparent;
            this.lblSetPair.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetPair.ForeColor = System.Drawing.Color.Tomato;
            this.lblSetPair.Location = new System.Drawing.Point(253, 117);
            this.lblSetPair.Name = "lblSetPair";
            this.lblSetPair.Size = new System.Drawing.Size(48, 32);
            this.lblSetPair.TabIndex = 3;
            this.lblSetPair.Text = "00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(253, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "00";
            // 
            // lblMove
            // 
            this.lblMove.AutoSize = true;
            this.lblMove.BackColor = System.Drawing.Color.Transparent;
            this.lblMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMove.ForeColor = System.Drawing.Color.Tomato;
            this.lblMove.Location = new System.Drawing.Point(12, 188);
            this.lblMove.Name = "lblMove";
            this.lblMove.Size = new System.Drawing.Size(197, 32);
            this.lblMove.TabIndex = 4;
            this.lblMove.Text = "Move counter";
            // 
            // EasyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1207, 688);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMove);
            this.Controls.Add(this.lblSetPair);
            this.Controls.Add(this.lblPair);
            this.Controls.Add(this.pnlFather);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EasyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EasyForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlFather;
        public System.Windows.Forms.Timer tmrShowCard;
        private System.Windows.Forms.Label lblPair;
        private System.Windows.Forms.Label lblSetPair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMove;
    }
}