using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZombieApocalypse
{
    public class Zombie
    {
        public Point Position { get; set; }
        public Image Image { get; set; }
        public bool Eating { get; set; }
        public bool Alive { get; set; }
        public int Velocity { get; set; }
        public Zombie(Point pos)
        {
            Position = pos;
            Image = Properties.Resources.zdown;
            Alive = true;
            Velocity = 4;
        }

        public void Draw(Graphics g)
        {
            g.DrawImage(Image, Position.X, Position.Y, 40, 40);
        }

        public void Move(Point HeroLocation)
        {
            int hor = Math.Abs(HeroLocation.X - Position.X);
            int ver = Math.Abs(HeroLocation.Y - Position.Y);

            if (Position.X > HeroLocation.X)
            {
                if (hor > ver)
                Image = Properties.Resources.zleft;
                Position = new Point(Position.X - Velocity, Position.Y);
            }

            if (Position.X < HeroLocation.X)
            {
                if (hor > ver)
                    Image = Properties.Resources.zright;
                Position = new Point(Position.X + Velocity, Position.Y);
            }

            if (Position.Y > HeroLocation.Y)
            {
                if (hor < ver)
                Image = Properties.Resources.zup;
                Position = new Point(Position.X, Position.Y - Velocity);
            }

            if (Position.Y < HeroLocation.Y)
            {
                if (hor < ver)
                    Image = Properties.Resources.zdown;
                Position = new Point(Position.X, Position.Y + Velocity);
            }
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
