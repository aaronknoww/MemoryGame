namespace MemeryGame.View
{
    partial class HardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HardForm));
            this.btbRestart = new System.Windows.Forms.Button();
            this.lblSetTime = new System.Windows.Forms.Label();
            this.lblTimeLeft = new System.Windows.Forms.Label();
            this.lblSetCount = new System.Windows.Forms.Label();
            this.lblMove = new System.Windows.Forms.Label();
            this.lblSetPair = new System.Windows.Forms.Label();
            this.lblPair = new System.Windows.Forms.Label();
            this.pnlFather = new System.Windows.Forms.Panel();
            this.tmrShowCard = new System.Windows.Forms.Timer(this.components);
            this.tmrSeconds = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btbRestart
            // 
            this.btbRestart.BackColor = System.Drawing.Color.Transparent;
            this.btbRestart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btbRestart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btbRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btbRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbRestart.ForeColor = System.Drawing.Color.PowderBlue;
            this.btbRestart.Location = new System.Drawing.Point(12, 528);
            this.btbRestart.Name = "btbRestart";
            this.btbRestart.Size = new System.Drawing.Size(172, 59);
            this.btbRestart.TabIndex = 24;
            this.btbRestart.Text = "Restart";
            this.btbRestart.UseVisualStyleBackColor = false;
            this.btbRestart.Click += new System.EventHandler(this.btbRestart_Click);
            // 
            // lblSetTime
            // 
            this.lblSetTime.AutoSize = true;
            this.lblSetTime.BackColor = System.Drawing.Color.Transparent;
            this.lblSetTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSetTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetTime.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblSetTime.Location = new System.Drawing.Point(755, 42);
            this.lblSetTime.Name = "lblSetTime";
            this.lblSetTime.Size = new System.Drawing.Size(195, 38);
            this.lblSetTime.TabIndex = 23;
            this.lblSetTime.Text = "60 seconds";
            // 
            // lblTimeLeft
            // 
            this.lblTimeLeft.AutoSize = true;
            this.lblTimeLeft.BackColor = System.Drawing.Color.Transparent;
            this.lblTimeLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTimeLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeLeft.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblTimeLeft.Location = new System.Drawing.Point(568, 42);
            this.lblTimeLeft.Name = "lblTimeLeft";
            this.lblTimeLeft.Size = new System.Drawing.Size(160, 38);
            this.lblTimeLeft.TabIndex = 22;
            this.lblTimeLeft.Text = "Time left:";
            // 
            // lblSetCount
            // 
            this.lblSetCount.AutoSize = true;
            this.lblSetCount.BackColor = System.Drawing.Color.Transparent;
            this.lblSetCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetCount.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblSetCount.Location = new System.Drawing.Point(287, 213);
            this.lblSetCount.Name = "lblSetCount";
            this.lblSetCount.Size = new System.Drawing.Size(55, 38);
            this.lblSetCount.TabIndex = 21;
            this.lblSetCount.Text = "00";
            // 
            // lblMove
            // 
            this.lblMove.AutoSize = true;
            this.lblMove.BackColor = System.Drawing.Color.Transparent;
            this.lblMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMove.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblMove.Location = new System.Drawing.Point(12, 213);
            this.lblMove.Name = "lblMove";
            this.lblMove.Size = new System.Drawing.Size(227, 38);
            this.lblMove.TabIndex = 20;
            this.lblMove.Text = "Move counter";
            this.lblMove.EnabledChanged += new System.EventHandler(this.lblMove_EnabledChanged);
            // 
            // lblSetPair
            // 
            this.lblSetPair.AutoSize = true;
            this.lblSetPair.BackColor = System.Drawing.Color.Transparent;
            this.lblSetPair.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetPair.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblSetPair.Location = new System.Drawing.Point(287, 142);
            this.lblSetPair.Name = "lblSetPair";
            this.lblSetPair.Size = new System.Drawing.Size(55, 38);
            this.lblSetPair.TabIndex = 19;
            this.lblSetPair.Text = "00";
            // 
            // lblPair
            // 
            this.lblPair.AutoSize = true;
            this.lblPair.BackColor = System.Drawing.Color.Transparent;
            this.lblPair.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPair.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblPair.Location = new System.Drawing.Point(12, 142);
            this.lblPair.Name = "lblPair";
            this.lblPair.Size = new System.Drawing.Size(267, 38);
            this.lblPair.TabIndex = 18;
            this.lblPair.Text = "Remaining pairs";
            // 
            // pnlFather
            // 
            this.pnlFather.Location = new System.Drawing.Point(348, 102);
            this.pnlFather.Name = "pnlFather";
            this.pnlFather.Size = new System.Drawing.Size(700, 600);
            this.pnlFather.TabIndex = 17;
            this.pnlFather.EnabledChanged += new System.EventHandler(this.pnlFather_EnabledChanged);
            // 
            // tmrShowCard
            // 
            this.tmrShowCard.Interval = 300;
            this.tmrShowCard.Tick += new System.EventHandler(this.tmrShowCard_Tick);
            // 
            // tmrSeconds
            // 
            this.tmrSeconds.Interval = 1000;
            this.tmrSeconds.Tick += new System.EventHandler(this.tmrSeconds_Tick);
            // 
            // HardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.btbRestart);
            this.Controls.Add(this.lblSetTime);
            this.Controls.Add(this.lblTimeLeft);
            this.Controls.Add(this.lblSetCount);
            this.Controls.Add(this.lblMove);
            this.Controls.Add(this.lblSetPair);
            this.Controls.Add(this.lblPair);
            this.Controls.Add(this.pnlFather);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HardForm";
            this.Text = "Hard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btbRestart;
        private System.Windows.Forms.Label lblSetTime;
        private System.Windows.Forms.Label lblTimeLeft;
        private System.Windows.Forms.Label lblSetCount;
        private System.Windows.Forms.Label lblMove;
        private System.Windows.Forms.Label lblSetPair;
        private System.Windows.Forms.Label lblPair;
        private System.Windows.Forms.Panel pnlFather;
        private System.Windows.Forms.Timer tmrShowCard;
        private System.Windows.Forms.Timer tmrSeconds;
    }
}