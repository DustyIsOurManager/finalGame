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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnMage_Click(object sender, EventArgs e)
        {
            locationStartMage locationMage = new locationStartMage();
            locationMage.ShowDialog(); // Shows the Mage location chooser
            this.Close();
        }

        private void btnKnight_Click(object sender, EventArgs e)
        {
            locationStartKnight locationKnight = new locationStartKnight();
            locationKnight.ShowDialog(); // Shows the Knight location chooser
            this.Close();
        }
        private void btnOrc_Click_1(object sender, EventArgs e)
        {
            locationStartOrc locationOrc = new locationStartOrc();
            locationOrc.ShowDialog(); // Shows the Orc location chooser
            this.Close();
        }

        private void btnAssassin_Click(object sender, EventArgs e)
        {
            locationStartAssassin locationAssassin = new locationStartAssassin();
            locationAssassin.ShowDialog(); // Shows the Assassin location chooser
            this.Close();  
        }
    }
}
