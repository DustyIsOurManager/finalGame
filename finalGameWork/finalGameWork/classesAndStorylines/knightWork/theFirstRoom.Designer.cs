namespace gameStart.classesAndStorylines.knightWork
{
    partial class theFirstRoom
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
            this.btnFirstRoom1 = new System.Windows.Forms.Button();
            this.btnFirstRoom2 = new System.Windows.Forms.Button();
            this.btnFirstRoom4 = new System.Windows.Forms.Button();
            this.btnFirstRoom3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the first room";
            // 
            // btnFirstRoom1
            // 
            this.btnFirstRoom1.Location = new System.Drawing.Point(44, 91);
            this.btnFirstRoom1.Name = "btnFirstRoom1";
            this.btnFirstRoom1.Size = new System.Drawing.Size(180, 66);
            this.btnFirstRoom1.TabIndex = 1;
            this.btnFirstRoom1.Text = "You go down";
            this.btnFirstRoom1.UseVisualStyleBackColor = true;
            this.btnFirstRoom1.Click += new System.EventHandler(this.btnFirstRoom1_Click);
            // 
            // btnFirstRoom2
            // 
            this.btnFirstRoom2.Location = new System.Drawing.Point(277, 91);
            this.btnFirstRoom2.Name = "btnFirstRoom2";
            this.btnFirstRoom2.Size = new System.Drawing.Size(188, 66);
            this.btnFirstRoom2.TabIndex = 2;
            this.btnFirstRoom2.Text = "Exit and enter the second room";
            this.btnFirstRoom2.UseVisualStyleBackColor = true;
            this.btnFirstRoom2.Click += new System.EventHandler(this.btnFirstRoom2_Click);
            // 
            // btnFirstRoom4
            // 
            this.btnFirstRoom4.Location = new System.Drawing.Point(277, 172);
            this.btnFirstRoom4.Name = "btnFirstRoom4";
            this.btnFirstRoom4.Size = new System.Drawing.Size(188, 66);
            this.btnFirstRoom4.TabIndex = 3;
            this.btnFirstRoom4.Text = "Exit and go up the long staircase";
            this.btnFirstRoom4.UseVisualStyleBackColor = true;
            this.btnFirstRoom4.Click += new System.EventHandler(this.btnFirstRoom4_Click);
            // 
            // btnFirstRoom3
            // 
            this.btnFirstRoom3.Location = new System.Drawing.Point(44, 172);
            this.btnFirstRoom3.Name = "btnFirstRoom3";
            this.btnFirstRoom3.Size = new System.Drawing.Size(180, 66);
            this.btnFirstRoom3.TabIndex = 4;
            this.btnFirstRoom3.Text = "Exite and Enter the third room";
            this.btnFirstRoom3.UseVisualStyleBackColor = true;
            this.btnFirstRoom3.Click += new System.EventHandler(this.btnFirstRoom3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(263, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "You will find a little staircase that leadsto the basement";
            // 
            // theFirstRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 250);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFirstRoom3);
            this.Controls.Add(this.btnFirstRoom4);
            this.Controls.Add(this.btnFirstRoom2);
            this.Controls.Add(this.btnFirstRoom1);
            this.Controls.Add(this.label1);
            this.Name = "theFirstRoom";
            this.Text = "theFirstRoom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFirstRoom1;
        private System.Windows.Forms.Button btnFirstRoom2;
        private System.Windows.Forms.Button btnFirstRoom4;
        private System.Windows.Forms.Button btnFirstRoom3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}