using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovingFigures
{
    public class Randomizer
    {

        public static int RandPoint(int maxPoint) {
             return new Random().Next(0, maxPoint);
        }

        public static int RandVelocity(int minValRange, int maxValRange)
        {

            int exclude = 0;
            int numb;
           
            numb = new Random().Next(minValRange, maxValRange);
            if (numb == exclude) numb++;

            return numb;
        }

    }
}
