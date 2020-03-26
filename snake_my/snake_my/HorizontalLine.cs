using System;
using System.Collections.Generic;
using System.Text;

namespace snake_my
{
    class HorizontalLine
    {
        List<point> plist;
        public HorizontalLine(int xLeft, int xRight, int y, char sym)
        {
            plist = new List<point>();

            for(int x = xLeft; x <= xRight; x++) 
            {
                point p = new point(x, y, sym);
                plist.Add(p);
            }

        }
        public void Draw()
        {
            foreach(point p in plist)
            {
                p.draw();
            }
        }
    }
}
