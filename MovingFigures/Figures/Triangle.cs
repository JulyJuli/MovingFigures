﻿using System;
using System.Drawing;
using RandomizerLib;
using System.Xml.Serialization;

namespace MovingFigures
{
    [Serializable(), XmlInclude(typeof(Triangle)), SoapInclude(typeof(Triangle))]
    public class Triangle : Figures
    {
        public bool f = true;
        private Random r = new Random();
        private int x, y, dx, dy;
        public Triangle() { }
        public Triangle(string type, Color color) : base(type, color)
        {
            this.Type = type; this.Color = color;
            x = Randomizer.RandPoint(200);
            y = Randomizer.RandPoint(200);
            dx = Randomizer.RandVelocity(-4, 4);
            dy = Randomizer.RandVelocity(-4, 4);
        }

        public override void Draw(Graphics g)
        {
         
            Point[] points = { new Point(x, y), new Point(x + 20, y), new Point(x + 10, y + 20) };
        g.DrawPolygon(new Pen(Color), points);
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
        public override Point CountCenterCoordinates()
        {
            return new Point(x, y);
        }
    }
}
