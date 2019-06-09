using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ZombieApocalypse
{
    public class Level1
    {
       
        public bool Shoots;
        public Hero hero;
        public int width, height;
        public List<Zombie> zombies;
        public List<AmmoGift> gifts;
        public int Count;
        Random r;
        public Boss boss;
        public bool hasBoss;
        public Level1(int Width, int Height, ref Hero h, Random rand)
        {
            hero = h;
            width = Width;
            height = Height;
            Shoots = false;
            zombies = new List<Zombie>();
            zombies.Add(new Zombie(new Point(100, 100)));

            r = rand;
            boss = new Boss(r.Next(0, r.Next(0, Height - 40)));
            gifts = new List<AmmoGift>();
            hasBoss = false;

            Count = 0;
           
        }
        public void Resize(int w, int h)
        {
            height = h;
            width = w;
        }
        public bool timer1()
        {
            try
            {
                hero.MoveBullets(width, height);
                if (hero.Kills >= 2)
                    hasBoss = true;
                foreach (Bullet b in hero.Bullets)
                {
                    foreach (Zombie z in zombies)
                    {
                        if (b.isHit(z.Position))
                        {
                            z.Alive = false;
                            b.Alive = false;
                            hero.Kills++;
                        }
                    }

                    if (hasBoss)
                    {
                        if (b.isHit(boss.Position))
                        {
                            boss.Health -= 20;
                            b.Alive = false;
                       
                        }

                        if (boss.Health <= 0)
                        {
                            hasBoss = false;

                            return true;
                            
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
            catch (Exception exc)
            {
                return false;
            }
            return false;
        }
        public bool timer2(int Width, int Height)
        {
            Count++;
            if (hero.Kills >= 2)
                boss.Move(hero.Position);

            foreach (Zombie z in zombies)
            {
                z.Move(hero.Position);

                if (z.isHit(hero.Position))
                {
                    hero.Health -= 2;

                    if (hero.Health == 0)
                    {
                     
                        
                        hero.Image = Properties.Resources.dead;
                        return true;
                    }
                   
                }
            }
            if (hasBoss)
            {
                if (boss.isHit(hero.Position))
                {
                    hero.Health -= 30;

                    if (hero.Health <= 0)
                    {


                        hero.Image = Properties.Resources.dead;
                        return true;
                    }

                }
            }
            if (Count % 70 == 0 && hasBoss == false)
            {
                int top = r.Next(0, 2);
                zombies.Add(new Zombie(new Point(r.Next(0, width - 30), top == 0 ? 50 : Height - 40)));
                 top = r.Next(0, 2);
                zombies.Add(new Zombie(new Point(r.Next(0, width - 30), top == 0 ? 50 : Height - 40)));
                 top = r.Next(0, 2);
                zombies.Add(new Zombie(new Point(r.Next(0, width - 30), top == 0 ? 50 : Height - 40)));
            }

            if (Count % 150 == 0)
                gifts.Add(new AmmoGift(new Point(r.Next(0, Width - 50), r.Next(30, Height - 50))));

            foreach (AmmoGift g in gifts)
            {
                g.Count++;

                if (g.Count == 100)
                    g.Alive = false;
            }
            return false;
          
        }
        public void Move(int number)
        {

            if (number == 4)
                Shoots = true;
          
            foreach (AmmoGift g in gifts)
            {
                if (g.isHit(hero.Position))
                {
                    hero.Ammo += 5;
                }
            }

            for (int i = gifts.Count - 1; i >= 0; i--)
            {
                if (!gifts[i].Alive)
                {
                    gifts.RemoveAt(i);
                }
            }

        }
        public void Paint(Graphics graphics)
        {
            
            hero.DrawBullets(graphics);
            foreach (Zombie z in zombies)
            {
                z.Draw(graphics);
            }

            foreach (AmmoGift gift in gifts)
            {
                gift.Draw(graphics);
            }
            if (Shoots == true)
            {
                hero.Shoot();
                Shoots = false;
            }

            if (hasBoss)
            {
                boss.Draw(graphics);
                hasBoss = true;
            }
        }
        public void endGame()
        {
            gifts.Clear();
            zombies.Clear();
            boss = null; 
        }
    }
}
