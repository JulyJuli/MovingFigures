using System;
using System.Collections;
using System.Drawing;
using System.Media;
using System.Threading;

namespace MovingFigures
{
    public static class Utils
    {
        public static String CountDistanse(Point p1, Point p2) {
            int result = (Int16)Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));
            string s = null;

            if (result < 8) {

                s = p1.X + ";" + p1.Y + ")";

            }
            return s;
        }

        static SoundPlayer player = new SoundPlayer(MovingFigures.Properties.Resources.beep_03);

        public static void MyBeep(String message) {
            player.Play();
            Console.WriteLine("Beep!");
            Console.WriteLine(message);
        }

        private static ArrayList threadList = new ArrayList();

        public static void ThreadPool(Thread thread)
        {
            threadList.Add(thread);
           
            
            Console.WriteLine(thread.Name + " this is a name") ;
        }

        public static void RemoveFromThreadPool() {
            threadList.RemoveAt(0);
        }

        static readonly object obj = new object();
    }
}
