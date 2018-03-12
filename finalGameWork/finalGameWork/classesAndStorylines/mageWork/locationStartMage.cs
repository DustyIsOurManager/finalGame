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
    public partial class locationStartMage : Form
    {
        public locationStartMage()
        {
            InitializeComponent();
        }

        private void btnForestStart_Click(object sender, EventArgs e)
        {
            mageStoryForest mageStoryForest = new mageStoryForest();
            mageStoryForest.ShowDialog(); // Shows the knight storyline
            this.Close();
        }

        private void btnCastleStart_Click(object sender, EventArgs e)
        {
            mageStoryCastle mageStoryCastle = new mageStoryCastle();
            mageStoryCastle.ShowDialog(); // Shows the knight storyline
            this.Close();
        }
    }
}
