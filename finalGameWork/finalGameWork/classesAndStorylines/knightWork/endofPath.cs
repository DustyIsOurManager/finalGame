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


        private void button2_Click(object sender, EventArgs e)
        {
            winScreen win= new winScreen();
            win.ShowDialog(); // Shows the win screen
        }
    }
}
