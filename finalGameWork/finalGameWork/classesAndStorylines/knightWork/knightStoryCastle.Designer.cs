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
            this.btnEndGame = new System.Windows.Forms.Button();
            this.btnBackDoor = new System.Windows.Forms.Button();
            this.lblCastleStart = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEndGame
            // 
            this.btnEndGame.Location = new System.Drawing.Point(193, 373);
            this.btnEndGame.Name = "btnEndGame";
            this.btnEndGame.Size = new System.Drawing.Size(160, 50);
            this.btnEndGame.TabIndex = 0;
            this.btnEndGame.Text = "Go in through the front door";
            this.btnEndGame.UseVisualStyleBackColor = true;
            this.btnEndGame.Click += new System.EventHandler(this.btnEndGame_Click);
            // 
            // btnBackDoor
            // 
            this.btnBackDoor.Location = new System.Drawing.Point(550, 373);
            this.btnBackDoor.Name = "btnBackDoor";
            this.btnBackDoor.Size = new System.Drawing.Size(162, 50);
            this.btnBackDoor.TabIndex = 1;
            this.btnBackDoor.Text = "Make your way around to the back door\r\n";
            this.btnBackDoor.UseVisualStyleBackColor = true;
            this.btnBackDoor.Click += new System.EventHandler(this.btnBackDoor_Click);
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
            this.Controls.Add(this.btnBackDoor);
            this.Controls.Add(this.btnEndGame);
            this.Name = "knightStoryCastle";
            this.Text = "knightStoryCastle";
            this.Load += new System.EventHandler(this.knightStoryCastle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEndGame;
        private System.Windows.Forms.Button btnBackDoor;
        private System.Windows.Forms.Label lblCastleStart;
    }
}