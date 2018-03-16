namespace gameStart.classesAndStorylines.knightWork
{
    partial class backDoor
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
            this.btnRoomOne = new System.Windows.Forms.Button();
            this.btnLongStaircase = new System.Windows.Forms.Button();
            this.btnRoomThree = new System.Windows.Forms.Button();
            this.btnRoomTwo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(161, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Back Door";
            // 
            // btnRoomOne
            // 
            this.btnRoomOne.Location = new System.Drawing.Point(26, 71);
            this.btnRoomOne.Name = "btnRoomOne";
            this.btnRoomOne.Size = new System.Drawing.Size(236, 79);
            this.btnRoomOne.TabIndex = 1;
            this.btnRoomOne.Text = "Enter the first room";
            this.btnRoomOne.UseVisualStyleBackColor = true;
            // 
            // btnLongStaircase
            // 
            this.btnLongStaircase.Location = new System.Drawing.Point(311, 177);
            this.btnLongStaircase.Name = "btnLongStaircase";
            this.btnLongStaircase.Size = new System.Drawing.Size(217, 73);
            this.btnLongStaircase.TabIndex = 2;
            this.btnLongStaircase.Text = "Go up a long staircase";
            this.btnLongStaircase.UseVisualStyleBackColor = true;
            // 
            // btnRoomThree
            // 
            this.btnRoomThree.Location = new System.Drawing.Point(26, 177);
            this.btnRoomThree.Name = "btnRoomThree";
            this.btnRoomThree.Size = new System.Drawing.Size(236, 73);
            this.btnRoomThree.TabIndex = 3;
            this.btnRoomThree.Text = "Enter the third room";
            this.btnRoomThree.UseVisualStyleBackColor = true;
            // 
            // btnRoomTwo
            // 
            this.btnRoomTwo.Location = new System.Drawing.Point(311, 71);
            this.btnRoomTwo.Name = "btnRoomTwo";
            this.btnRoomTwo.Size = new System.Drawing.Size(217, 79);
            this.btnRoomTwo.TabIndex = 4;
            this.btnRoomTwo.Text = "Enter the second room";
            this.btnRoomTwo.UseVisualStyleBackColor = true;
            this.btnRoomTwo.Click += new System.EventHandler(this.btnRoomTwo_Click);
            // 
            // backDoor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 262);
            this.Controls.Add(this.btnRoomTwo);
            this.Controls.Add(this.btnRoomThree);
            this.Controls.Add(this.btnLongStaircase);
            this.Controls.Add(this.btnRoomOne);
            this.Controls.Add(this.label1);
            this.Name = "backDoor";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRoomOne;
        private System.Windows.Forms.Button btnLongStaircase;
        private System.Windows.Forms.Button btnRoomThree;
        private System.Windows.Forms.Button btnRoomTwo;
    }
}