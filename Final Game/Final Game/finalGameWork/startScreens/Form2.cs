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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnContinue1_Click(object sender, EventArgs e)
        {
            Form3 characterChooseForm = new Form3();
            characterChooseForm.ShowDialog(); // Shows Form3 aka the character selection screen
        }
    }
}
