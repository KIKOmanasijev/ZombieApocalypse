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
        public Hero.Direction Direction { get; set; }
        public Zombie()
        {

        }
        public Zombie(Point pos)
        {
            Position = pos;
            Image = Properties.Resources.zdown;
            Alive = true;
            Velocity = 4;
            Direction = Hero.Direction.Down;
        }
        

        public virtual void Draw(Graphics g)
        {
            g.DrawImage(Image, Position.X, Position.Y, 40, 40);
        }
       
        public virtual void Move(Point HeroLocation)
        {
            int hor = Math.Abs(HeroLocation.X - Position.X);
            int ver = Math.Abs(HeroLocation.Y - Position.Y);

            if (Position.X > HeroLocation.X)
            {
                if (hor > ver)
                {
                    Image = Properties.Resources.zleft;
                    Direction = Hero.Direction.Left;
                }
                Position = new Point(Position.X - Velocity, Position.Y);
            }

            if (Position.X < HeroLocation.X)
            {
                if (hor > ver)
                {
                    Image = Properties.Resources.zright;
                    Direction = Hero.Direction.Right;
                }
                Position = new Point(Position.X + Velocity, Position.Y);
            }

            if (Position.Y > HeroLocation.Y)
            {
                if (hor < ver)
                {
                    Image = Properties.Resources.zup;
                    Direction = Hero.Direction.Up;
                }
                Position = new Point(Position.X, Position.Y - Velocity);
            }

            if (Position.Y < HeroLocation.Y)
            {
                if (hor < ver)
                {
                    Image = Properties.Resources.zdown;
                    Direction = Hero.Direction.Down;
                }
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
