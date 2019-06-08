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
    public partial class Form1 : Form
    {
        public bool Shoots;
        public Hero kiro;
        public int width, height;
        public List<Zombie> zombies;
        public List<AmmoGift> gifts;
        public int Count;
        Random r;
        public Boss boss;
        public bool hasBoss;

        public Form1()
        {
            InitializeComponent();
           
            kiro = new Hero(this.Width, this.Height);
            width = this.Width;
            height = this.Height;
            Shoots = false;
            zombies = new List<Zombie>();
            zombies.Add(new Zombie(new Point(100, 100)));
            timer1.Start();
            timer2.Start();
            r = new Random();
            boss = new Boss(r.Next(0, r.Next(0, this.Height - 40)));
            gifts = new List<AmmoGift>();
            hasBoss = false;

            Count = 0;
            this.DoubleBuffered = true;
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            kiro.Draw(e.Graphics);
            kiro.DrawBullets(e.Graphics);
            foreach(Zombie z in zombies)
            {
                z.Draw(e.Graphics);
            }

            foreach(AmmoGift gift in gifts)
            {
                gift.Draw(e.Graphics);
            }
            if (Shoots == true)
            {
                kiro.Shoot();
                Shoots = false;
            }

            if (hasBoss)
            {
                boss.Draw(e.Graphics);
                hasBoss = true;
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Invalidate(true);
            height = this.Height;
            width = this.Width;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                kiro.MoveBullets(width, height);
                if (kiro.Kills >= 1)
                    hasBoss = true;
                foreach (Bullet b in kiro.Bullets)
                {
                    foreach (Zombie z in zombies)
                    {
                        if (b.isHit(z.Position))
                        {
                            z.Alive = false;
                            b.Alive = false;
                            kiro.Kills++;
                        }
                    }

                    if (hasBoss)
                    {
                        if (b.isHit(boss.Position))
                        {
                            boss.Health -= 20;
                            b.Alive = false;
                            Invalidate(true);
                        }

                        if (boss.Health <= 0)
                        {
                            hasBoss = false;

                            endgame();
                            Invalidate(true);
                        }
                    }


                }

                for (int i = zombies.Count - 1; i >= 0; i--)
                {
                    if (!zombies[i].Alive)
                    {
                        zombies.RemoveAt(i);
                    }
                }
            }
            catch(Exception exc)
            {

            }
            Invalidate(true);
        }

        private void StatusStrip1_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                AmmoText.Text = "Ammo: " + kiro.Ammo.ToString();
               
                HeroHealth.Value = kiro.Health;
                kills.Text = "Kills: " + kiro.Kills.ToString();
            } catch (Exception exception)
            {
                
            }
            
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            Count++;
            if (kiro.Kills >= 1)
                 boss.Move(kiro.Position);

            foreach (Zombie z in zombies)
            {
                z.Move(kiro.Position);

                if (z.isHit(kiro.Position))
                {
                    kiro.Health -= 2;

                    if (kiro.Health == 0)
                    {
                        timer1.Stop();
                        timer2.Stop();
                        kiro.Image = Properties.Resources.dead;
                        MessageBox.Show("GAME END");
                    }
                    Invalidate(true);
                }
            }

            if (Count % 70 == 0 && hasBoss == false)
            {
                int top = r.Next(0, 2);
                zombies.Add(new Zombie(new Point(r.Next(0, width - 30), top == 0 ? 50 : Height - 40)));
                zombies.Add(new Zombie(new Point(r.Next(0, width - 30), top == 0 ? 50 : Height - 40)));
                zombies.Add(new Zombie(new Point(r.Next(0, width - 30), top == 0 ? 50 : Height - 40)));
            }

            if (Count % 150 == 0)
                gifts.Add(new AmmoGift(new Point(r.Next(0, Width - 50), r.Next(30, Height - 50))));

            foreach(AmmoGift g in gifts)
            {
                g.Count++;

                if (g.Count == 100)
                    g.Alive = false;
            }
            
        }

        private void HeroHealth_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Up")
                kiro.Move(width, height, 0);
            if (e.KeyCode.ToString() == "Right")
                kiro.Move(width, height, 1);
            if (e.KeyCode.ToString() == "Down")
                kiro.Move(width, height, 2);
            if (e.KeyCode.ToString() == "Left")
                kiro.Move(width, height, 3);
            if (e.KeyCode.ToString() == "Space")
                Shoots = true;

            foreach(AmmoGift g in gifts)
            {
                if (g.isHit(kiro.Position))
                {
                    kiro.Ammo += 5;
                }
            }

            for (int i = gifts.Count - 1; i >= 0; i--)
            {
                if (!gifts[i].Alive)
                {
                    gifts.RemoveAt(i);
                }
            }
            Invalidate(true);
        }

        public void endgame()
        {
            timer1.Stop();
            timer2.Stop();
            gifts.Clear();
            zombies.Clear();
            boss = null;
            MessageBox.Show("You won level 1!");
        }

    }
}
