using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tetris2
{
    class FigureS: Figure
    {
        public FigureS()
        {
            pList = new List<Point>();

            Point p1 = new Point(0, 1);
            Point p2 = new Point(1, 1);
            Point p3 = new Point(1, 0);
            Point p4 = new Point(2, 0);
            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);
            pList.Add(p4);
        }

    }
}
