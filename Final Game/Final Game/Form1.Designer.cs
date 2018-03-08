namespace Final_Game
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblTile = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblDelete = new System.Windows.Forms.Label();
            this.picStart = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picStart)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // lblTile
            // 
            this.lblTile.AutoSize = true;
            this.lblTile.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTile.Font = new System.Drawing.Font("Jokerman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTile.ForeColor = System.Drawing.Color.DimGray;
            this.lblTile.Location = new System.Drawing.Point(12, 60);
            this.lblTile.Name = "lblTile";
            this.lblTile.Size = new System.Drawing.Size(769, 93);
            this.lblTile.TabIndex = 1;
            this.lblTile.Text = "Misfortune of Medieval\r\n";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnStart.Font = new System.Drawing.Font("Buxton Sketch", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnStart.Location = new System.Drawing.Point(103, 306);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(325, 63);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Click Here To Start\r\n";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblDelete
            // 
            this.lblDelete.Location = new System.Drawing.Point(290, 142);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(262, 143);
            this.lblDelete.TabIndex = 3;
            this.lblDelete.Text = "label2";
            // 
            // picStart
            // 
            this.picStart.Image = global::Final_Game.Properties.Resources.images;
            this.picStart.Location = new System.Drawing.Point(434, 169);
            this.picStart.Name = "picStart";
            this.picStart.Size = new System.Drawing.Size(340, 261);
            this.picStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStart.TabIndex = 4;
            this.picStart.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::Final_Game.Properties.Resources.images;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(786, 442);
            this.Controls.Add(this.picStart);
            this.Controls.Add(this.lblDelete);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblTile);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picStart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTile;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblDelete;
        private System.Windows.Forms.PictureBox picStart;
    }
}

