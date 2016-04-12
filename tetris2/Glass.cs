using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tetris2
{
    class Glass: Figure
    {
        public Glass()
        {
            pList = new List<Point>();

            for (int i = 0; i < 25; i++)
            {
                Point p = new Point(0, i);
                pList.Add(p);
            }
            for (int i = 0; i < 79; i++)
            {
                Point p = new Point(i, 25);
                pList.Add(p);
            }
            for (int i = 0; i < 25; i++)
            {
                Point p = new Point(79, i);
                pList.Add(p);
            }
        }

    }
}
