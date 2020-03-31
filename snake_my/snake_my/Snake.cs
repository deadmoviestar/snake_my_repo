using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace snake_my
{
    class Snake:Figure
              
    {
        Direction direction;
        public Snake(point tail, int length, Direction direction)
        {
            plist = new List<point>();
            for (int i = 0; i < length; i++)
            {
                point p = new point(tail);
                p.Move(i, direction);
                plist.Add(p);
            } 
                
        }

        internal void Move()
        {
            point tail = plist.First();
            plist.Remove(tail);
            point head = GetNextPoint();
            plist.Add(head);

            tail.Clear;
            head.draw;

        }

        public point GetNextPoint;
    }
}
