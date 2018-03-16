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
    public partial class knightStoryForest : Form
    {
        public knightStoryForest()
        {
            InitializeComponent();
        }

        private void knightStory_Load(object sender, EventArgs e)
        {
  
        }

        private void lblKnightForestStart_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            knightPathContinue knightPathContinue = new knightPathContinue();
            knightPathContinue.ShowDialog(); // Shows the Knight location chooser
            this.Close();
        }

       
    }
}
