using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tetris2
{
    class FLine : Figure
    {
        public FLine()
        {
            pList = new List<Point>();
            
            Point p1 = new Point(0, 0);
            Point p2 = new Point(0, 1);
            Point p3 = new Point(0, 2);
            Point p4 = new Point(0, 3);
            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);
            pList.Add(p4);


        }

    //    public FLine(int xLeft, int xRight, int y, char sym)
    //    {
    //        pList = new List<Point>();
    //        for (int x = xLeft; x <= xRight; x++)
    //        {
    //            Point p = new Point(x, y, sym);
    //            pList.Add(p);
    //        }
    //    }

    //    public void HandleKey(ConsoleKey key)
    //    {
    //        if (key == ConsoleKey.LeftArrow)
    //            moveLeftPerStep();
    //        else if (key == ConsoleKey.RightArrow)
    //            moveRightPerStep();
    //        //else if (key == ConsoleKey.DownArrow)
    //        //    moveDownPerStep();
    //    }

    //}
}
