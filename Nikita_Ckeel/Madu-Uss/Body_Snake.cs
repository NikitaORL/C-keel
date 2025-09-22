using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikita_Ckeel
{
    class Body_Snake : Figure
    {
        Direction direction;
        public Body_Snake(Point tail, int length, Direction direction)
        {
            direction = _direction;
            pList = new List<Point>();
            for (int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }
        internal void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add(head);

            tail.Clear();
            head.Draw();
        }
    }
}
