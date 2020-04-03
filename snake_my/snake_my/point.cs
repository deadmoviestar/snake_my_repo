using System;

namespace snake_my
{
    class point
    {
        public int x;
        public int y;
        public char sym;
        
        public point()
        {
        }
        public point(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }
        public point(point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }
        public void Move(int offset, Direction direction)
        {
            if (direction == Direction.right)
            {
                x = x + offset;
            }
            else if (direction == Direction.left)
            {
                x = x - offset;
            }
            else if (direction == Direction.up)
            {
                y = y - offset;
            }
            else if (direction == Direction.down)
            {
                y = y + offset;
            }
        }
        public void draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

        public void clear()
        {
            sym=' ';
            draw();
        }

        public override string ToString()
        {
            return x + "," + y + "," + sym;
        }
    }
}
