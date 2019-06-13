using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZombieApocalypse
{
    public class Level2
    {
        public bool Shoots;
        public Hero hero;
        public int Width { get; set; }
        public int Height { get; set; }
        public List<Bullet> BossBullets { get; set; }
        public List<Bullet> ZombieBullets { get; set; }
        public List<Zombie> zombies;
        public List<AmmoGift> gifts;
        public int Count;
        Random r;
        public Boss boss { get; set; }
        public bool hasBoss;
        public Level2(ref Hero h, int w, int he, Random rand)
        {
            Shoots = false;
            Width = w;
            Height = he;
            hero = h;
            r = rand;
            zombies = new List<Zombie>();
            gifts = new List<AmmoGift>();
            Zombie newZoombie = new Zombie(new Point(100, 100));
            zombies.Add(newZoombie);
            ZombieBullets = new List<Bullet>();
            boss = new Boss(r.Next(0, r.Next(0, Height - 40)));
            hasBoss = false;
            BossBullets = new List<Bullet>();
        }
        public void Paint(Graphics g)
        {
           foreach(var item in zombies)
            {
                item.Draw(g);
            }
            foreach (var item in ZombieBullets)
                item.Draw(g);

            hero.DrawBullets(g);
            

            foreach (AmmoGift gift in gifts)
            {
                gift.Draw(g);
            }
            if (Shoots == true)
            {
                hero.Shoot();
                Shoots = false;
            }

            if (hasBoss)
            {
                foreach(Bullet b in BossBullets)
                {
                    b.DrawBossBullets(g);
                }
                boss.Draw(g);
                hasBoss = true;
            }
        }
        public void Move()
        {
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
        public bool timer2()
        {
            Count++;
            if (hero.Kills >= 10)
                boss.Move(hero.Position);

            foreach (Zombie z in zombies)
            {
                z.Move(hero.Position);

                if (z.isHit(hero.Position))
                {
                    hero.Health -= 2;

                    if (hero.Health <= 0)
                    {
                            hero.Image = Properties.Resources.dead;
                            return true;
                     
                    }

                }
            }

            if (Count % 70 == 0)
            {
                int top = r.Next(0, 2);
                zombies.Add(new Zombie(new Point(r.Next(0, Width - 30), top == 0 ? 50 : Height - 40)));
                top = r.Next(0, 2);
                zombies.Add(new Zombie(new Point(r.Next(0, Width - 30), top == 0 ? 50 : Height - 40)));
                top = r.Next(0, 2);
                zombies.Add(new Zombie(new Point(r.Next(0, Width - 30), top == 0 ? 50 : Height - 40)));
            }
            if(Count % 50 == 0 || Count % 51 == 0 || Count % 52 == 0)
            {
                foreach(var item in zombies)
                {
                    ZombieBullets.Add(new Bullet(item.Position, item.Direction, Color.Green));
                  
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
                if (Count % 95 == 0 || Count % 96 == 0 || Count % 97 == 0)
                {
                    BossBullets.Add(new Bullet(boss.Position, boss.Direction, Color.Black, 20, 20));
                }
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
        public void endGame()
        {
            gifts.Clear();
            zombies.Clear();
            ZombieBullets.Clear();
        }
     
        

        public bool timer1(ref bool won)
        {
            try
            {
                foreach (var item in BossBullets)
                {
                    item.Move(Width, Height);
                }
                hero.MoveBullets(Width, Height);
                if (hero.Kills >= 10)
                    hasBoss = true;
                foreach (Bullet b in ZombieBullets)
                    {
                        b.Move(Width, Height);
                    }
                
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
                            won = true;
                            return false;
                            

                        }
                    }

                }
                foreach(Bullet b in ZombieBullets)
                {
                    if(b.isHit(hero.Position))
                    {
                        hero.Health -= 10;
                        if (hero.Health <= 0)
                        {
                            hero.Image = Properties.Resources.dead;
                            return true;
                        }
                        b.Alive = false;
                    }
                }

                foreach (Bullet b in BossBullets)
                {
                    if (b.isHit(hero.Position))
                    {
                        hero.Health -= 20;
                        if (hero.Health <= 0)
                        {
                            hero.Image = Properties.Resources.dead;
                            return true;
                        }
                        b.Alive = false;
                    }
                }

                for (int i = ZombieBullets.Count - 1; i >= 0; i--)
                {
                    if (!ZombieBullets[i].Alive)
                    {
                        ZombieBullets.RemoveAt(i);
                    }
                }
                for (int i = BossBullets.Count - 1; i >= 0; i--)
                {
                    if (!BossBullets[i].Alive)
                    {
                        BossBullets.RemoveAt(i);
                    }
                }
                for (int i = zombies.Count - 1; i >= 0; i--)
                {
                    if (!zombies[i].Alive)
                    {
                        zombies.RemoveAt(i);
                    }
                }
                return false;
            }
            catch (Exception exc)
            {
                return false;
            }
        }
        public void Resize(int w, int h)
        {
            Width = w;
            Height = h;
        }
    }
}
