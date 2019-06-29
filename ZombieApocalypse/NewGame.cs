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
    public partial class NewGame : Form
    {
        int width ;
         int   height;
        public string name;
        public NewGame()
        {
            InitializeComponent();
            this.BackgroundImage = Properties.Resources.bgNewGame;
            width = this.Width;
            height = this.Height;
            BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            name = NameHero.Text;
            DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void NameHero_Validating(object sender, CancelEventArgs e)
        {
            if(NameHero.Text == "")
            {
                errorProvider1.SetError(NameHero, "Name Required");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(NameHero, "");
                e.Cancel = false;
                name = NameHero.Text;
            }
        }

        private void NewGame_ResizeEnd(object sender, EventArgs e)
        {
            this.Width = width;
            this.Height = height;
        }

      
      
    }
}
