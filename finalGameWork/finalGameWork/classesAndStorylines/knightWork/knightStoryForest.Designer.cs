namespace gameStart
{
    partial class knightStoryForest
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
            this.lblKnightForestStart = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKnightForestStart
            // 
            this.lblKnightForestStart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblKnightForestStart.AutoSize = true;
            this.lblKnightForestStart.BackColor = System.Drawing.Color.Black;
            this.lblKnightForestStart.Location = new System.Drawing.Point(417, 133);
            this.lblKnightForestStart.Name = "lblKnightForestStart";
            this.lblKnightForestStart.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblKnightForestStart.Size = new System.Drawing.Size(0, 13);
            this.lblKnightForestStart.TabIndex = 0;
            this.lblKnightForestStart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblKnightForestStart.UseMnemonic = false;
            this.lblKnightForestStart.Click += new System.EventHandler(this.lblKnightForestStart_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 59);
            this.button1.TabIndex = 1;
            this.button1.Text = "Continue down the path";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(596, 280);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 59);
            this.button2.TabIndex = 2;
            this.button2.Text = "Go back towards a Town";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // knightStoryForest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::gameStart.Properties.Resources.forestStart;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(885, 459);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblKnightForestStart);
            this.Name = "knightStoryForest";
            this.Text = "knightStory";
            this.Load += new System.EventHandler(this.knightStory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKnightForestStart;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}