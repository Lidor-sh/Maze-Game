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
    public partial class Form1 : Form
    {
        string newgame = "";
        public Form1(string whattosave)
        {
            InitializeComponent();
            newgame = whattosave;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Levels le = new Levels(newgame);
            le.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            newgame = "newgame";
        }
    }
}
