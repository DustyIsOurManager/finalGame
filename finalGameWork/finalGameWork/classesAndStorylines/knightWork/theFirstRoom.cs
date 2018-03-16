using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gameStart.classesAndStorylines.knightWork
{
    public partial class theFirstRoom : Form
    {
        public theFirstRoom()
        {
            InitializeComponent();
        }

        private void btnFirstRoom1_Click(object sender, EventArgs e)
        {
            classesAndStorylines.knightWork.theFirstRoom f2 = new classesAndStorylines.knightWork.theFirstRoom();
            f2.ShowDialog(); // Shows frontDoor1
            this.Close();
        }

        private void btnFirstRoom2_Click(object sender, EventArgs e)
        {
            classesAndStorylines.knightWork.backDoor f2 = new classesAndStorylines.knightWork.backDoor();
            f2.ShowDialog(); // Shows frontDoor1
            this.Close();
        }

        private void btnFirstRoom3_Click(object sender, EventArgs e)
        {
            classesAndStorylines.knightWork.backDoor f2 = new classesAndStorylines.knightWork.backDoor();
            f2.ShowDialog(); // Shows frontDoor1
            this.Close();
        }

        private void btnFirstRoom4_Click(object sender, EventArgs e)
        {
            classesAndStorylines.knightWork.backDoor f2 = new classesAndStorylines.knightWork.backDoor();
            f2.ShowDialog(); // Shows frontDoor1
            this.Close();
        }
    }
}
