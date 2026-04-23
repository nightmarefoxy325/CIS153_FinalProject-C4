using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectFourProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SinglePlayer_Click(object sender, EventArgs e)
        {
            VsRobot robform = new VsRobot();
            robform.Show();
            this.Hide();
        }

        private void VsPlayer_Click(object sender, EventArgs e)
        {
            VsPlayer playform = new VsPlayer();
            playform.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Statistics_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
