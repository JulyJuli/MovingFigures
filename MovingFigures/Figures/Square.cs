using System;
using RandomizerLib;
using System.Drawing;
using System.Xml.Serialization;
using System.Threading;

namespace MovingFigures
{
    [Serializable(), XmlInclude(typeof(Square)), SoapInclude(typeof(Square))]
    public class Square : Figures
    {
        public bool f = true;
        private Random r = new Random();
        private int x, y, dx, dy;

        public Square() { }
        public Square(string type, Color color) : base(type, color)
        {
            this.Type = type; this.Color = color;
            x = Randomizer.RandPoint(200);
            y = Randomizer.RandPoint(200);
            dx = Randomizer.RandVelocity(-4, 4);
            dy = Randomizer.RandVelocity(-4, 4);
        }

        public override void Draw(Graphics g)
        {
            g.DrawRectangle(new Pen(Color), x, y, 20, 20);
        }

        public override void Move(Point maxPoint)
        {
            if (this.flag)
            {
                if (x >= maxPoint.X || x < 0) dx = -dx;

                if (y >= maxPoint.Y || y < 0) dy = -dy;

                x += dx;
                y += dy;
            }
        }

        public override Point CountCenterCoordinates() {

            return new Point(x, y);
        }
    }
}
