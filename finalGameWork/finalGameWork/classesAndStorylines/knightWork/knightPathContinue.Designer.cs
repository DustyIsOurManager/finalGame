namespace gameStart
{
    partial class knightPathContinue
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
            this.lblContinue = new System.Windows.Forms.Label();
            this.btnContinuePath = new System.Windows.Forms.Button();
            this.lblBear = new System.Windows.Forms.Label();
            this.btnAttack = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblContinue
            // 
            this.lblContinue.AutoSize = true;
            this.lblContinue.BackColor = System.Drawing.Color.Transparent;
            this.lblContinue.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblContinue.Location = new System.Drawing.Point(226, 143);
            this.lblContinue.Name = "lblContinue";
            this.lblContinue.Size = new System.Drawing.Size(301, 13);
            this.lblContinue.TabIndex = 14;
            this.lblContinue.Text = "Congratulations, you beat the bear! Press continue to continue";
            this.lblContinue.Visible = false;
            // 
            // btnContinuePath
            // 
            this.btnContinuePath.Location = new System.Drawing.Point(334, 186);
            this.btnContinuePath.Name = "btnContinuePath";
            this.btnContinuePath.Size = new System.Drawing.Size(75, 23);
            this.btnContinuePath.TabIndex = 13;
            this.btnContinuePath.Text = "Continue";
            this.btnContinuePath.UseVisualStyleBackColor = true;
            this.btnContinuePath.Visible = false;
            this.btnContinuePath.Click += new System.EventHandler(this.btnContinuePath_Click_1);
            // 
            // lblBear
            // 
            this.lblBear.AutoSize = true;
            this.lblBear.BackColor = System.Drawing.Color.Transparent;
            this.lblBear.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblBear.Location = new System.Drawing.Point(220, 76);
            this.lblBear.Name = "lblBear";
            this.lblBear.Size = new System.Drawing.Size(307, 39);
            this.lblBear.TabIndex = 12;
            this.lblBear.Text = "                    You come across a fork in the path. \r\nYou see a bear and a wa" +
    "y around it but don\'t know if it will work\r\n                                    " +
    "What do you do?";
            // 
            // btnAttack
            // 
            this.btnAttack.Location = new System.Drawing.Point(588, 316);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(131, 35);
            this.btnAttack.TabIndex = 11;
            this.btnAttack.Text = "Attack(High chance of death)";
            this.btnAttack.UseVisualStyleBackColor = true;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(426, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 35);
            this.button1.TabIndex = 10;
            this.button1.Text = "Sneak around it";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // knightPathContinue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::gameStart.Properties.Resources.bearFight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(731, 372);
            this.Controls.Add(this.lblContinue);
            this.Controls.Add(this.btnContinuePath);
            this.Controls.Add(this.lblBear);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.button1);
            this.Name = "knightPathContinue";
            this.Text = "knightPathContinue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblContinue;
        private System.Windows.Forms.Button btnContinuePath;
        private System.Windows.Forms.Label lblBear;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.Button button1;
    }
}