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
    public partial class locationStartKnight : Form
    {
        public locationStartKnight()
        {
            InitializeComponent();
        }

        private void btnForestStart_Click(object sender, EventArgs e)
        {
            knightStoryForest knightStoryForest = new knightStoryForest();
            knightStoryForest.ShowDialog(); // Shows the knight forest storyline
            this.Close();
        }

        private void btnCastleStart_Click(object sender, EventArgs e)
        {
            knightStoryCastle knightStoryCastle = new knightStoryCastle();
            knightStoryCastle.ShowDialog(); // Shows the knight castle storyline
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
