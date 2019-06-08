using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZombieApocalypse
{
    public class Bullet
    {
        public Point point;
        public Hero.Direction Direction;
        public bool Alive;
        
        public Bullet(Point point, Hero.Direction dir)
        {
            this.point = point;
            Direction = dir;
            Alive = true;
        }

        public void Draw(Graphics g)
        {
            Brush b = new SolidBrush(Color.OrangeRed);
            g.FillEllipse(b, point.X, point.Y, 5, 5);
        }

        public void Move(int Width, int Height)
        {
            if (Direction == Hero.Direction.Up)
            {
                point = new Point(point.X, point.Y - 3);
            }

            if (Direction == Hero.Direction.Right)
            {
                point = new Point(point.X + 3, point.Y);
            }

            if (Direction == Hero.Direction.Down)
            {
                point = new Point(point.X, point.Y + 3);
            }

            if (Direction == Hero.Direction.Left)
            {
                point = new Point(point.X - 3, point.Y);
            }


            if (point.X > Width)
                Alive = false;

            if (point.X < 0)
                Alive = false;

            if (point.Y < 0)
                Alive = false;

            if (point.Y > Height)
                Alive = false;
        }

        public bool isHit(Point HeroLocation)
        {
            if (point.X >= HeroLocation.X && point.X <= HeroLocation.X + 50 && point.Y >= HeroLocation.Y && point.Y <= HeroLocation.Y + 50)
                return true;
            else
                return false;

        }
    }
}
