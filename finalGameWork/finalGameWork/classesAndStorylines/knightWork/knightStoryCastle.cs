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
    public partial class knightStoryCastle : Form
    {
        public knightStoryCastle()
        {
            InitializeComponent();
        }

        private void knightStoryCastle_Load(object sender, EventArgs e)
        {
            lblCastleStart.Text = "You wake up in front of a nice looking castle" + Environment.NewLine + "despite being worn down the castle looks inviting." + Environment.NewLine + " You have nothing but leather armor on and 10 gold.";
        }

        private void btnEndGame_Click(object sender, EventArgs e)
        {
            //frontDoor f3 = new frontDoor();
            f3.Show();
            this.Close();
        }

        private void btnBackDoor_Click(object sender, EventArgs e)
        {
            backDoor backDoor = new backDoor();
            backDoor.ShowDialog(); 
            this.Close();
        }


    }
}
