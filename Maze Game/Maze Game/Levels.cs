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
    public partial class Levels : Form
    {
        string checklevel;
        public Levels(string levelscomplete)
        {
            InitializeComponent();
            if(levelscomplete=="level1complete")
            {
                checklevel = levelscomplete;
                xButton2.Enabled = true;
            }
            if(levelscomplete=="level2complete")
            {
                checklevel = levelscomplete;
                xButton2.Enabled = true;
                xButton3.Enabled = true;
            }
            if(levelscomplete=="level3complete")
            {
                checklevel = levelscomplete;
                xButton2.Enabled = true;
                xButton3.Enabled = true;
                xButton4.Enabled = true;
            }
        }

        private void Levels_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1(checklevel);
            fm.Show();
            this.Hide();
        }

        private void xButton4_Click(object sender, EventArgs e)
        {

        }

        private void xButton10_Click(object sender, EventArgs e)
        {

        }

        private void xButton14_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void xButton1_Click(object sender, EventArgs e)
        {
            Level1 lv1 = new Level1(checklevel);
            lv1.Show();
            this.Hide();
        }

        private void xButton2_Click(object sender, EventArgs e)
        {
            level2 lv1 = new level2(checklevel);
            lv1.Show();
            this.Hide();
        }

        private void xButton3_Click(object sender, EventArgs e)
        {
            Level3 lv3 = new Level3(checklevel);
            lv3.Show();
            this.Hide();
        }
    }
}
