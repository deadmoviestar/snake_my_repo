using System;
using System.Text;

namespace snake_my
{
    class Program
    {
        static void Main(string[] args)
        {
            point p1 = new point(1,3,'$');
            p1.draw();

            point p2 = new point(3,6,'^');
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
