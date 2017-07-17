using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maze_Game
{
    public partial class level2 : Form
    {
        private string completeornot;
        public level2(string checklevel)
        {
            completeornot = checklevel;
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
        private void MoveToStart()
        {
            Point p = new Point(23, 77);
            Cursor.Position = PointToScreen(p);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Levels lvs = new Levels(completeornot);
            lvs.Show();
            this.Hide();
        }
        private void Walltoch(object sender, EventArgs e)
        {
            MoveToStart();
        }

        private void label25_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Well done!" + Environment.NewLine + "Level 2 Complete");
            if (completeornot == "level1complete")
                completeornot = "level2complete";
            Levels lvs = new Levels(completeornot);
            lvs.Show();
            this.Hide();
        }

        private void level2_Load(object sender, EventArgs e)
        {
            MoveToStart();
        }
    }
}
