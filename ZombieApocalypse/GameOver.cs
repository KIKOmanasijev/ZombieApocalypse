using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZombieApocalypse
{
    public partial class GameOver : Form
    {
        string enemies;
        int width;
        int height;
        public GameOver(string enemies)
        {
            InitializeComponent();
            this.BackgroundImage = Properties.Resources._10;
            BackgroundImageLayout = ImageLayout.Stretch;
        
        width = this.Width;
            height = this.Height;
            this.enemies = enemies;
            EnemiesText.Text = "You kill " + this.enemies + " zoombies";
        }

        private void NewGame_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void GameOver_ResizeEnd(object sender, EventArgs e)
        {
            this.Width = width;
            this.Height = height;
        }
    }
}
