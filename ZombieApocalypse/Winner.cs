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

namespace ZombieApocalypse
{
    [Serializable]
    public partial class Winner : Form
    {
        Timer timer3;
        Random r;
        public Hero hero;
        int width;
        int height;
        HighScores highScores;
        public string FileName = "ZombieApocalypse";
        public Winner(Hero hero)
        {
            InitializeComponent();
            this.hero = hero;
            DoubleBuffered = true;
            width = this.Width;
            height = this.Height;
            Invalidate(true);
            highScores = null;
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
                highScores = new HighScores();
            }

           
            
            Invalidate(true);
            highScores.add(hero.Kills, hero.Name);
            r = new Random();
            timer3 = new Timer();
            timer3.Interval = 50;
            timer3.Tick += new EventHandler(timer3_tick);
            timer3.Start();
            using (FileStream fileStream = new FileStream(FileName, FileMode.Create))
            {
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fileStream, highScores);
            }

        }
     
       
        public void setKill(Hero her)
        {
            hero = her;
            textBox1.Text = "CONGRATULATIONS\n" + hero.Name +"\nYOU WON!";
            label2.Text = "You killed 2 BOSSES\n and \nYou Killed " + hero.Kills + " ZOMBIES";

        }
        private void timer3_tick(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255)); 
            Invalidate(true);
        }

        private void Winner_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.ForeColor = Color.Red;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.ForeColor = Color.Aqua;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void Winner_ResizeEnd(object sender, EventArgs e)
        {
            this.Width = width;
            this.Height = height;
        }
    }
}
