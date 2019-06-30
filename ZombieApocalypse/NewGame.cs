using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
namespace ZombieApocalypse
{
    [Serializable]
    public partial class NewGame : Form
    {
        int width ;
         int   height;
        public string name;
        public string FileName = "ZombieApocalypse";
        HighScores highScores;
        public WindowsMediaPlayer player = new WindowsMediaPlayer();
        public NewGame()
        {
            player.URL = "start.mp3";
            player.controls.play();
            try
            {
                InitializeComponent();
                
                viewHighScores();
                if(highScores != null)
                {
                    for(int i= highScores.highScores.Count-1; i>=0; i--)
                    {
                        
                        textBox2.Text +=  highScores.highScores[i].ToString() + " - " + highScores.names[highScores.highScores[i]] + Environment.NewLine;
                    }
                }
                this.BackgroundImage = Properties.Resources.picgr;
                width = this.Width;
                height = this.Height;
                BackgroundImageLayout = ImageLayout.Stretch;
            }
            catch(Exception ex)
            {
               
            }
        }
        public void viewHighScores()
        {
            try
            {
                using (FileStream fileStream = new FileStream(FileName, FileMode.Open))
                {
                    IFormatter formatter = new BinaryFormatter();
                    highScores = (HighScores)formatter.Deserialize(fileStream);
                }

            }
            catch (Exception ex)
            {
                FileName = "ZombieApocalypse";
            }
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

        private void button3_Click(object sender, EventArgs e)
        {
           DialogResult =  DialogResult.Cancel;
        }
    }
}
