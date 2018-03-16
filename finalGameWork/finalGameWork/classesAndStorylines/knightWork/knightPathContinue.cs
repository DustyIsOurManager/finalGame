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
    public partial class knightPathContinue : Form
    {
        public knightPathContinue()
        {
            InitializeComponent();
        }

        private void knightContinuePath_Load(object sender, EventArgs e)
        {

        }

        private void btnContinuePath_Click(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.castleStart;
        }

        private void btnAttack_Click_1(object sender, EventArgs e)
        {
            Random rNum = new Random();
            int rNum2 = rNum.Next(1, 100);
            if (rNum2 <= 50)
            {
                MessageBox.Show("You died and you are bad haha");
            }
            else
            {
                btnContinuePath.Visible = true;
                lblContinue.Visible = true;

            }
        }

        private void btnContinuePath_Click_1(object sender, EventArgs e)
        {
            endofPath endofPath = new endofPath();
            endofPath.ShowDialog(); // Continues after winning the bear fight
        }
    }
}
