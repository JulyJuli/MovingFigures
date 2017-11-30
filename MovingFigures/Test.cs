using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovingFigures
{
    class Test
    {
        unsafe static void Main(string[] args)
          
            {
                int a = 10;
                int* pointer;

                pointer = &a;

                Console.WriteLine(*pointer);
            }
        }

    }
