using System;
using System.Collections.Generic;

namespace snake_my
{
    class Program
    {
        static void Main(string[] args)
        {
            HorizontalLine line = new HorizontalLine(2, 10, 3, '#');
            line.Draw();

            Console.ReadLine();
        }
    }
}