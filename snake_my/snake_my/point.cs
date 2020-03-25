using System;
using System.Collections.Generic;
using System.Text;

namespace snake_my
{
    class point
    {
        public int x;
        public int y;
        public char sym;

        public void draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
