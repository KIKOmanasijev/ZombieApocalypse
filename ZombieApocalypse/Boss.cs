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
        
        public Boss(int y)
        {
            Health = 100;
            Velocity = 5;
            Image = Properties.Resources.bright;
            Position = new Point(30, y);
        }

        public void Move(Point HeroLocation)
        {
            int hor = Math.Abs(HeroLocation.X - Position.X);
            int ver = Math.Abs(HeroLocation.Y - Position.Y);

            if (Position.X > HeroLocation.X)
            {
                if (hor > ver)
                    Image = Properties.Resources.bleft;
                Position = new Point(Position.X - Velocity, Position.Y);
            }

            if (Position.X < HeroLocation.X)
            {
                if (hor > ver)
                    Image = Properties.Resources.bright;
                Position = new Point(Position.X + Velocity, Position.Y);
            }

            if (Position.Y > HeroLocation.Y)
            {
                Position = new Point(Position.X, Position.Y - Velocity);
            }

            if (Position.Y < HeroLocation.Y)
            {
                Position = new Point(Position.X, Position.Y + Velocity);
            }
        }
        
        public void Draw(Graphics g)
        {
            g.DrawImage(Image, Position.X, Position.Y, 75, 75);
        }
    }
}
