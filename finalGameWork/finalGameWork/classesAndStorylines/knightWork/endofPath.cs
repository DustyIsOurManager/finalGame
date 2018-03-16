using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gameStart
{
    public partial class endofPath : Form
    {
        public endofPath()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
        private System.Windows.Forms.Timer timer1;
        private int counter = 60;
        private void endofPath_Load(object sender, EventArgs e)
        {
            
            for (int X = 45; X > 0 ;)
            {
                timer1 = new System.Windows.Forms.Timer();
                timer1.Tick += new EventHandler(timer1_Tick);
                timer1.Interval = 1000; // 1 second
                timer1.Start();
                lblCountDown.Text = counter.ToString();
             
            }
            
              
             
           
        }
    }
}
