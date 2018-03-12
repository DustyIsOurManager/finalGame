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
            lblKnightForestStart.Text = ("You wake up dazed in a forest with no memory of how you got there or what you are doing." + Environment.NewLine + "You still have all of your armor and your sword is sitting on the logs next to you" + Environment.NewLine + "but all of your gold has been stolen");
        }

        private void lblKnightForestStart_Click(object sender, EventArgs e)
        {

        }

       
    }
}
