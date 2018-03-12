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
    public partial class locationStartAssassin : Form
    {
        public locationStartAssassin()
        {
            InitializeComponent();
        }

        private void btnForestStart_Click(object sender, EventArgs e)
        {
            assassinStoryForest assassinStoryForest = new assassinStoryForest();
            assassinStoryForest.ShowDialog(); // Shows the knight storyline
            this.Close();
        }

        private void btnCastleStart_Click(object sender, EventArgs e)
        {
            assassinStoryCastle assassinStoryCastle = new assassinStoryCastle();
            assassinStoryCastle.ShowDialog(); // Shows the knight storyline
            this.Close();
        }
    }
}
