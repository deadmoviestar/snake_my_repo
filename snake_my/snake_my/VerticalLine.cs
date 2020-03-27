using System;
using System.Collections.Generic;
using System.Text;

namespace snake_my
{
    class VerticalLine: Figure
    {
        public VerticalLine(int yUp, int yDown, int x, char sym)
        {
            plist = new List<point>();

            for (int y = yUp; y <= yDown; y++)
            {
                point p = new point(x, y, sym);
                plist.Add(p);
            }

        }
    }
}
