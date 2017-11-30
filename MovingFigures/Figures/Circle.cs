using System;
using System.Drawing;
using RandomizerLib;
using System.Xml.Serialization;

namespace MovingFigures
{
    [Serializable(), XmlInclude(typeof(Circle)), SoapInclude(typeof(Circle))]
    public class Circle : Figures
    {
        private int x, y, dx, dy;
        public Circle() { }
        public Circle(string type, Color color) : base(type, color){ 
            this.Type = type; this.Color = color;
            x = Randomizer.RandPoint(200);
            y = Randomizer.RandPoint(200);
            dx = Randomizer.RandVelocity(-4,4);
            dy = Randomizer.RandVelocity(-4,4);
        }

        public override void Draw(Graphics g)
        {
           
            g.DrawEllipse(new Pen(Color), x, y, 20, 20);
        }

        public override void Move(Point maxPoint)
        {
            if (this.flag)
            {

                if (x >= maxPoint.X || x <= 0) dx = -dx;

                if (y >= maxPoint.Y || y <= 0) dy = -dy;

                x += dx;
                y += dy;
            }
          
        }


        public override Point CountCenterCoordinates()
        {

            return new Point(x, y);
        }


    }
}