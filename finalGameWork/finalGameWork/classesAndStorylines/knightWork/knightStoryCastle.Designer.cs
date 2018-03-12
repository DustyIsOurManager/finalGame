namespace gameStart
{
    partial class knightStoryCastle
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblCastleStart = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(193, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Go in through the front door";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(550, 373);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 50);
            this.button2.TabIndex = 1;
            this.button2.Text = "Make your way around to the back";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lblCastleStart
            // 
            this.lblCastleStart.AutoSize = true;
            this.lblCastleStart.Location = new System.Drawing.Point(424, 222);
            this.lblCastleStart.Name = "lblCastleStart";
            this.lblCastleStart.Size = new System.Drawing.Size(0, 13);
            this.lblCastleStart.TabIndex = 2;
            // 
            // knightStoryCastle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::gameStart.Properties.Resources.castleStart;
            this.ClientSize = new System.Drawing.Size(969, 515);
            this.Controls.Add(this.lblCastleStart);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "knightStoryCastle";
            this.Text = "knightStoryCastle";
            this.Load += new System.EventHandler(this.knightStoryCastle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblCastleStart;
    }
}