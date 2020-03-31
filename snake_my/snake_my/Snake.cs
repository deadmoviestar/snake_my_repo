using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
    }
}
