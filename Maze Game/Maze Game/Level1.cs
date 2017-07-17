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
    public partial class Level1 : Form
    {
        string completeornot;
        public Level1(string checklevel)
        {
            completeornot = checklevel;
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Walltoch(object sender, EventArgs e)
        {
            MoveToStart();
        }
        private void MoveToStart()
        {
            Point p = new Point(23,77);
            Cursor.Position = PointToScreen(p);

        }

        private void Level1_Load(object sender, EventArgs e)
        {
            MoveToStart();
        }

        private void label25_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Well done!" + Environment.NewLine + "Level 1 Complete");
            if (completeornot == null)
                completeornot = "level1complete";
            Levels lvs = new Levels(completeornot);
            lvs.Show();
            this.Hide();
        }

        private void label39_Click(object sender, EventArgs e)
        {

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
    }
}
