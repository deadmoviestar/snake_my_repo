using System;
using System.Text;

namespace snake_my
{
    class Program
    {
        static void Main(string[] args)
        {
            point p1 = new point();
            p1.x = 1;
            p1.y = 1;
            p1.sym = '*';

            p1.draw();

            point p2 = new point();

            p2.x = 3;
            p2.y = 6;
            p2.sym= '^';

            p2.draw();

            Console.ReadLine();
        }
        static void draw(int x, int y, char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

    } 
}
