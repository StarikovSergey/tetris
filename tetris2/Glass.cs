using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tetris2
{
    class Glass: Figure
    {
        public Glass(int xLeft, int xRight )
        {
            pList = new List<Point>();

            for (int i = 0; i < Console.BufferHeight-1; i++)
            {
                Point p = new Point(xLeft, i);
                pList.Add(p);
            }

            for (int i = 0; i < Console.BufferHeight-1; i++)
            {
                Point p = new Point(xRight, i);
                pList.Add(p);
            }
        }

        public Glass(int y)
        {
            pList = new List<Point>();

            for (int i = 0; i < Console.BufferWidth; i++)
            {
                Point p = new Point(i,y);
                pList.Add(p);
            }

        }


        public List<Point> add(Figure f)
        {
            List<Point> fList = f.getCurrent();
            foreach (Point p in fList)
            {
                pList.Add(p);
            }
            return pList;
        }

    }
}
