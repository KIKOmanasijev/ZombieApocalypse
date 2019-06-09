using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZombieApocalypse
{
    public class Hero
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public Point Position { get; set; }
        public Image Image { get; set; }
        public Direction Dir { get; set; }
        public List<Bullet> Bullets { get; set; }
        public int Ammo { get; set; }
        public int Kills { get; set; }

        public enum Direction
        {
            Up,
            Left,
            Right,
            Down
        }
        public Hero(int Width, int Height, string Name)
        {
            Health = 100;
            Position = new Point(Width / 2, Height / 2);
            Image = Properties.Resources.up;
            Dir = Direction.Up;
            Bullets = new List<Bullet>();
            Ammo = 20;
            Kills = 0;
            this.Name = Name;
        }

        public void Draw(Graphics g)
        {
            g.DrawImage(Image, Position.X, Position.Y, 50, 50);
        }

        public void Move(int Width, int Height, int Dir)
        {
            if (Dir == 0)
            {
                this.Dir = Direction.Up;
                Image = Properties.Resources.up;

                Position = new Point(Position.X, Position.Y - 10);

                if (Position.Y < 30)
                {
                    Position = new Point(Position.X, 10);
                }
            }

            if (Dir == 1)
            {
                this.Dir = Direction.Right;
                Image = Properties.Resources.right;

                Position = new Point(Position.X + 10, Position.Y);

                if (Position.X > Width - 60)
                {
                    Position = new Point(Width - 60, Position.Y);
                }
            }

            if (Dir == 2)
            {
                this.Dir = Direction.Down;
                Image = Properties.Resources.down;

                Position = new Point(Position.X, Position.Y + 10);

                if (Position.Y > Height - 80)
                {
                    Position = new Point(Position.X, Height - 80);
                }
            }

            if (Dir == 3)
            {
                this.Dir = Direction.Left;
                Image = Properties.Resources.left;

                Position = new Point(Position.X - 10, Position.Y);

                if (Position.X < 0)
                {
                    Position = new Point(0, Position.Y);
                }
            }
        }

        public void Shoot()
        {
            Point p = new Point(Position.X + 25, Position.Y + 25);
            if (Ammo > 0)
            {
                Bullets.Add(new Bullet(p, Dir, Color.OrangeRed));
                Ammo--;
            }
            
        }

        public void MoveBullets(int width, int height)
        {
            foreach(Bullet b in Bullets)
            {
                b.Move(width, height);
            }
        }

        public void DrawBullets(Graphics g)
        {
            foreach (Bullet b in Bullets)
            {
                b.Draw(g);
            }

            for (int i = Bullets.Count - 1; i >= 0; i--)
            {
                if (!Bullets[i].Alive)
                Bullets.RemoveAt(i);
            }
        }
    }
}
