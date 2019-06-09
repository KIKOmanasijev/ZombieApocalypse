﻿using System;
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
  
    public partial class Form1 : Form
    {
        GameOver GameOver;
        Random random; 
        public Level1 level1doc;
        public Level2 level2doc;
        public Hero hero;
        NewGame newGame1;
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            newGame();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                hero.Draw(e.Graphics);
                if (level1doc != null)
                level1doc.Paint(e.Graphics);
            else if(level2doc != null)
                level2doc.Paint(e.Graphics);
            }
            catch(Exception ex)
            {
                
            }

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            try
            {
                if(level1doc != null)
                level1doc.Resize(this.Width, this.Height);
                else if(level1doc != null)
                level2doc.Resize(Width, Height);
            }
            catch(Exception ex)
            {

            }
            Invalidate(true);
        
        }
        public void newGame()
        {
            newGame1 = new NewGame();
            if (newGame1.ShowDialog() == DialogResult.OK)
            {
                hero = new Hero(Width, Height, newGame1.name);
                random = new Random();
                
                level1doc = new Level1(this.Width, this.Height, ref hero, random);
                level2doc = null;

                timer1.Start();
                timer2.Start();
              
            }
            else
            {
                this.Close();
            }
          
        }
        public void gameover()
        {
           
          
            GameOver = new GameOver(hero.Kills.ToString());
            
            timer1.Stop();
            timer2.Stop();
            if (level1doc != null)
                level1doc.endGame();
            else if (level2doc != null)
                level2doc.endGame();
            if (GameOver.ShowDialog() == DialogResult.OK)
            {
                
                newGame();
            }
            else
            {
                this.Close();
            }
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (level1doc != null)
            {
               if (level1doc.timer1())
                {
                    level2();
                }
            }
            bool won = false;
            if(level2doc != null)
            {
                if(level2doc.timer1(ref won))
                {
                    hero.Image = Properties.Resources.dead;
                    gameover();
                }
                if(won)
                {
                    winner();
                }
            }
            Invalidate(true);
        }
        public void winner()
        {
            timer1.Stop();
            timer2.Stop();
            level2doc.endGame();
            MessageBox.Show("You won!");
          
        }
        private void StatusStrip1_Paint(object sender, PaintEventArgs e)
        {
          
            try
            {
                  AmmoText.Text = "Ammo: " + hero.Ammo.ToString();
                HeroHealth.ForeColor = Color.Green;
                if (hero.Health < 20)
                    HeroHealth.ForeColor = Color.Red;
                else if (hero.Health < 30)
                    HeroHealth.ForeColor = Color.Orange;
                else if (hero.Health < 50)
                    HeroHealth.ForeColor = Color.Yellow;
                
                    HeroHealth.Value =hero.Health;
                    kills.Text = "Kills: " + hero.Kills.ToString();
                HeroName1.Text = "Hero's Name: " + hero.Name;

            } catch (Exception exception)
            {
                
            }
            
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
           
                
            if (level1doc != null)
            {
                if(level1doc.timer2(Width, Height))
                {
                    hero.Image = Properties.Resources.dead;
                    gameover();
                }
             
            }
            if(level2doc != null)
            {
                if (level2doc.timer2())
                {
                    hero.Image = Properties.Resources.dead;
                    gameover(); 
                }
            }
            
            
            Invalidate(true);
        }

        private void HeroHealth_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            try
            {
                if (e.KeyCode.ToString() == "Up")
                    hero.Move(Width, Height, 0);
                if (e.KeyCode.ToString() == "Right")
                    hero.Move(Width, Height, 1);
                if (e.KeyCode.ToString() == "Down")
                    hero.Move(Width, Height, 2);
                if (e.KeyCode.ToString() == "Left")
                    hero.Move(Width, Height, 3);
                if (e.KeyCode.ToString() == "Space")
                {
                    if (level1doc != null)
                        level1doc.Move(4);
                    else if (level2doc != null)
                        level2doc.Shoots = true;
                }
                if (level1doc != null)
                    level1doc.Move(1);
                if (level2doc != null)
                    level2doc.Move();
            }
            catch(Exception ec)
            { }
         
            Invalidate(true);
        }

        public void level2()
        {

            timer1.Stop();
            timer2.Stop();
            level1doc.endGame();
            MessageBox.Show("You won Level1!", "Next Level", MessageBoxButtons.OK);
            levelText.Text = "Level 2";
            level1doc = null;
            level2doc = new Level2(ref hero, Width, Height, random);
            timer1.Start();
            timer2.Start();
            Invalidate(true);
                
        }

    }
}
