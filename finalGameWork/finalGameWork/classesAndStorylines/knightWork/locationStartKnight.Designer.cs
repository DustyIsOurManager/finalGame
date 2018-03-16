namespace gameStart
{
    partial class locationStartKnight
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
            this.btnCastleStart = new System.Windows.Forms.Button();
            this.btnForestStart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCastleStart
            // 
            this.btnCastleStart.Location = new System.Drawing.Point(610, 284);
            this.btnCastleStart.Name = "btnCastleStart";
            this.btnCastleStart.Size = new System.Drawing.Size(104, 40);
            this.btnCastleStart.TabIndex = 18;
            this.btnCastleStart.Text = "Castle(Hard)";
            this.btnCastleStart.UseVisualStyleBackColor = true;
            this.btnCastleStart.Click += new System.EventHandler(this.btnCastleStart_Click);
            // 
            // btnForestStart
            // 
            this.btnForestStart.Location = new System.Drawing.Point(98, 283);
            this.btnForestStart.Name = "btnForestStart";
            this.btnForestStart.Size = new System.Drawing.Size(109, 41);
            this.btnForestStart.TabIndex = 17;
            this.btnForestStart.Text = "Forest(Easy)";
            this.btnForestStart.UseVisualStyleBackColor = true;
            this.btnForestStart.Click += new System.EventHandler(this.btnForestStart_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Choose your start location";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::gameStart.Properties.Resources.castleStart;
            this.pictureBox6.Location = new System.Drawing.Point(512, 139);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(294, 138);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 16;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::gameStart.Properties.Resources.forestStart;
            this.pictureBox5.Location = new System.Drawing.Point(22, 139);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(276, 138);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 15;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // locationStartKnight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 462);
            this.Controls.Add(this.btnCastleStart);
            this.Controls.Add(this.btnForestStart);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label2);
            this.Name = "locationStartKnight";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCastleStart;
        private System.Windows.Forms.Button btnForestStart;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label2;
    }
}