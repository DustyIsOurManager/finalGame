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
    public partial class locationStartOrc : Form
    {
        public locationStartOrc()
        {
            InitializeComponent();
        }

        private void btnForestStart_Click(object sender, EventArgs e)
        {
            orcStoryForest orcStoryForest = new orcStoryForest();
            orcStoryForest.ShowDialog(); // Shows the knight storyline
            this.Close();
        }

        private void btnCastleStart_Click(object sender, EventArgs e)
        {
            orcStoryCastle orcStoryCastle = new orcStoryCastle();
            orcStoryCastle.ShowDialog(); // Shows the knight storyline
            this.Close();
        }

        
    }
}
