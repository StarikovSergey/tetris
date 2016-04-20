using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tetris2
{
    class FigureL : Figure
    {
        public FigureL()
        {
            pList = new List<Point>();

            Point p1 = new Point(3, 0);
            Point p2 = new Point(3, 1);
            Point p3 = new Point(2, 1);
            Point p4 = new Point(1, 1);
            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);
            pList.Add(p4);
        }

    }
}
