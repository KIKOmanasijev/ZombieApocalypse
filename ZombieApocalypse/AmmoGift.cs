using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZombieApocalypse
{
    public class AmmoGift
    {
        public Point Position;
        public Image Image;
        public bool Alive;
        public int Count;

        public AmmoGift(Point p)
        {
            Position = p;
            Count = 0;
            Alive = true;
            Image = Properties.Resources.ammo_Image;
        }

        public void Draw(Graphics g)
        {
            if (Alive == true)
            g.DrawImage(Image, Position.X, Position.Y, 25, 25);
        }

        public bool isHit(Point HeroLocation)
        {
            if (Position.X >= HeroLocation.X && Position.X <= HeroLocation.X + 50 && Position.Y >= HeroLocation.Y && Position.Y <= HeroLocation.Y + 50)
            {
                Alive = false;
                return true;
            } else
            {
                return false;
            }
        }
    }
}
