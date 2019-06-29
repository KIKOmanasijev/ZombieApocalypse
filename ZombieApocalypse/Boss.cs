using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZombieApocalypse
{
    public class Boss
    {
        public Point Position;
        public Image Image;
        public int Health;
        public int Velocity;
        public Hero.Direction Direction { get; set; }
        public Boss()
        {

        }
        public Boss(int y)
        {
            Health = 100;
            Velocity = 5;
            Image = Properties.Resources.bright2;
            Direction = Hero.Direction.Right;
            Position = new Point(30, y);
        }

        public virtual void Move(Point HeroLocation)
        {
            int hor = Math.Abs(HeroLocation.X - Position.X);
            int ver = Math.Abs(HeroLocation.Y - Position.Y);

            if (Position.X > HeroLocation.X)
            {
                if (hor > ver)
                {
                    Image = Properties.Resources.bleft1;
                    Direction = Hero.Direction.Left;
                }
                Position = new Point(Position.X - Velocity, Position.Y);
            }

            if (Position.X < HeroLocation.X)
            {
                if (hor > ver)
                {
                    Image = Properties.Resources.bright2;
                    Direction = Hero.Direction.Right;
                }
                Position = new Point(Position.X + Velocity, Position.Y);
            }

            if (Position.Y > HeroLocation.Y)
            {
                if (hor < ver)
                {
                    Image = Properties.Resources.bright2;
                    Direction = Hero.Direction.Up;
                }
                Position = new Point(Position.X, Position.Y - Velocity);
            }

            if (Position.Y < HeroLocation.Y)
            {
                if (hor < ver)
                {
                    Image = Properties.Resources.bright2;
                    Direction = Hero.Direction.Down;
                }
                Position = new Point(Position.X, Position.Y + Velocity);
            }
        }
        
        public void Draw(Graphics g)
        {
            g.DrawImage(Image, Position.X, Position.Y, 75, 75);
        }
        public bool isHit(Point HeroLocation)
        {
            if (Position.X >= HeroLocation.X && Position.X <= HeroLocation.X + 50 && Position.Y >= HeroLocation.Y && Position.Y <= HeroLocation.Y + 50)
                return true;
            else
                return false;

        }
    }
}
