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
       
        public string name;
        public NewGame()
        {
            InitializeComponent();
          
            
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
    }
}
