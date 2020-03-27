using System;
using System.Collections.Generic;
using System.Text;

namespace snake_my
{
    class Figure
    {
        protected List<point> plist;

        public void Draw()
        {
            foreach (point p in plist)
            {
                p.draw();
            }
        }
    }
}
