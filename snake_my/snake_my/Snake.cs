using System;
using System.Collections.Generic;
using System.Linq;

namespace snake_my
{
    class Snake:Figure
              
    {
        Direction direction;
        public Snake(point tail, int length, Direction _direction)
        {
            direction = _direction;
            plist = new List<point>();
            for (int i = 0; i < length; i++)
            {
                point p = new point(tail);
                p.Move(i, direction);
                plist.Add(p);
            } 
                
        }

        public void Move()
        {
            point tail = plist.First();
            plist.Remove(tail);
            point head = GetNextPoint();
            plist.Add(head);

            tail.clear();
            head.draw();

        }

            public point GetNextPoint()
        {
            point head = plist.Last();
            point nextPoint = new point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }

        public void Hanlekey(ConsoleKey key)
        {
           if (key == ConsoleKey.LeftArrow)
                direction = Direction.left;
            else if (key == ConsoleKey.RightArrow)
                direction = Direction.right;
            else if (key == ConsoleKey.UpArrow)
                direction = Direction.up;
            else if (key == ConsoleKey.DownArrow)
                direction = Direction.down;
        }

        internal bool Eat(point food)
        {
            point head = GetNextPoint();
            if (head.IsHit(food))
            {
                food.sym = head.sym;
                plist.Add(food);
                return true;
            }
            else
                return false;
        }
    }
}
