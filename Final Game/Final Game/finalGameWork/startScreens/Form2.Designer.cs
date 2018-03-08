namespace gameStart
{
    partial class Form2
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnContinue1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 33F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(12, 86);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(727, 52);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome to Misfortune Of Medevial!";
            // 
            // btnContinue1
            // 
            this.btnContinue1.BackColor = System.Drawing.Color.Black;
            this.btnContinue1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinue1.ForeColor = System.Drawing.Color.Red;
            this.btnContinue1.Location = new System.Drawing.Point(218, 212);
            this.btnContinue1.Name = "btnContinue1";
            this.btnContinue1.Size = new System.Drawing.Size(290, 66);
            this.btnContinue1.TabIndex = 1;
            this.btnContinue1.Text = "Continue";
            this.btnContinue1.UseVisualStyleBackColor = false;
            this.btnContinue1.Click += new System.EventHandler(this.btnContinue1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(756, 430);
            this.Controls.Add(this.btnContinue1);
            this.Controls.Add(this.lblWelcome);
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnContinue1;
    }
}