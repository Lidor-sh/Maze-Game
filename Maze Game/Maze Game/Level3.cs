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
    public partial class Level3 : Form
    {
        private string completeornot;
        public Level3(string checklevel)
        {
            completeornot = checklevel;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Levels lvs = new Levels(completeornot);
            lvs.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label25_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Well done!" + Environment.NewLine + "Level 3 Complete");
            if (completeornot == "level2complete")
                completeornot = "level3complete";
            Levels lvs = new Levels(completeornot);
            lvs.Show();
            this.Hide();
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            MoveToStart();
        }
        private void MoveToStart()
        {
            Point p = new Point(23, 77);
            Cursor.Position = PointToScreen(p);

        }

        private void label45_Click(object sender, EventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label41_Click(object sender, EventArgs e)
        {

        }

        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void label43_Click(object sender, EventArgs e)
        {

        }

        private void label42_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label44_Click(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void label40_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }
        bool flag = true;
        private void timer1_Tick_1(object sender, EventArgs e)
        {
                if (flag)
                {
                    label45.Visible = true;
                    label45.Enabled = true;
                    flag = !flag;
                }
                else
                {
                    label45.Visible = false;
                    label45.Enabled = false;
                    flag = !flag;
                }
        }

        private void Level3_Load(object sender, EventArgs e)
        {
            timer1.Start();
            MoveToStart();
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            MoveToStart();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
