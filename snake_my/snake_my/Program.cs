﻿using System;
using System.Collections.Generic;

namespace snake_my
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(1, 1);
            Console.SetBufferSize(80, 25);
            Console.SetWindowSize(80, 25);

            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '#');
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '#');
            VerticalLine leftLine = new VerticalLine(0, 24, 0, '#');
            VerticalLine rightLine = new VerticalLine(0, 24, 78, '#');
            upLine.Draw();
            downLine.Draw();
            leftLine.Draw();
            rightLine.Draw();


            point p = new point(4,5,'*');
            p.draw();
        }
    }
}