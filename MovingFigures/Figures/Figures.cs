using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Xml.Serialization;

namespace MovingFigures
{
    [Serializable(), XmlInclude(typeof(Circle)), XmlInclude(typeof(Square)), XmlInclude(typeof(Triangle))]
    public abstract  class Figures
    {

        public bool flag = true;
        public bool kickFlag = false;
        private int X { get; set; }
        private int Y { get; set; }

        public delegate void MethodContainer(string message);
        public event MethodContainer OnKick;


        public Figures()

        { }
        public Figures(string type, Color color)
        { this.Type = type; this.Color = color; }

        public String Type { get; set; }
        public Point Point { get; set; }
        public Color Color { get; set; }



        abstract public void Draw(Graphics g);
        virtual public void Move(Point maxPoint) { }
        virtual public Point CountCenterCoordinates() { return new Point(X, Y); }
     
        public void Kick(Figures selectedFig, List<Figures> actions)
        {

            foreach (Figures f in actions)
            {
                if (!f.Equals(selectedFig))
                {
                    Point othersFig = f.CountCenterCoordinates();
                    Point forSelectedFig = selectedFig.CountCenterCoordinates();

                    string result = Utils.CountDistanse(forSelectedFig, othersFig);
                    if (result != null)
                    {
                        String s = selectedFig.Type + " collided with " + f.Type + " in coordinates : (" + result +'\n' + "----------------------------------------------";
                        OnKick?.Invoke(s);
                       
                    }
                }
            }
        }

    }

    }

