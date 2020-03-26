using System;
using System.Collections.Generic;

namespace snake_my
{
    class Program
    {
        static void Main(string[] args)
        {
            point p1 = new point(1, 3, '$');
            p1.draw();

            point p2 = new point(3, 6, '^');
            p2.draw();

            point p3 = new point(6, 6, '$');
            p3.draw();

            point p4 = new point(8, 8, '^');
            p4.draw();

            List<int> numlist = new List<int>();

            numlist.Add(0);
            numlist.Add(3);
            numlist.Add(4);

            int x = numlist[0];
            int y = numlist[1];
            int z = numlist[2];

            foreach (int i in numlist)
            {
                Console.WriteLine(i);
            }

            numlist.RemoveAt(0);

            List<point> pl = new List<point>();

            pl.Add(p1);
            pl.Add(p2);
            pl.Add(p3);
            pl.Add(p4);
            Console.ReadLine();
        }
    }
}
