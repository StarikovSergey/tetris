using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tetris2
{
    class Figure
    {
        protected Point currentPos;
        protected Point lastPos;
        protected List<Point> pList;

        public Figure()
        {
            currentPos = new Point();
            lastPos = new Point();
        }

        private void setPos(int x, int y)
        {
            lastPos.x = currentPos.x;
            lastPos.y = currentPos.y;
            currentPos.x = x;
            currentPos.y = y;
        }

        private void setPos(Point p)
        {
            currentPos.x = p.x;
            currentPos.y = p.y;
        }

        public List<Point> getCurrent()
        {
            List<Point> currentFigure = new List<Point>();
            foreach (Point p in pList)
            {
                Point tempP = new Point();
                tempP.x = currentPos.x + p.x;
                tempP.y = currentPos.y + p.y;
                currentFigure.Add(tempP);
            }
            return currentFigure;
        }

        public void moveDownPerStep()
        {
            setPos(currentPos.x, currentPos.y + 1);
        }
        public void moveLeftPerStep()
        {
            setPos(currentPos.x - 1, currentPos.y);
        }

        public void moveRightPerStep()
        {
            setPos(currentPos.x + 1, currentPos.y);
        }

        public void moveRotate()
        {
            foreach (Point p in pList)
            {
                int temp = p.x;
                p.x = -(p.y);
                p.y = temp;
            }
        }

        public void DiscardLastMove()
        {
            currentPos = lastPos;
        }





        public void DrawFigure(char sym)
        {
            List<Point> tempList = getCurrent();

            foreach (Point p in tempList)
            {
                Console.SetCursorPosition(p.x, p.y);
                Console.Write(sym);
            }

        }
        public bool IsHit(Figure figure)
        {
            foreach (Point p in pList)
            {
                if (figure.IsHit(p))
                    return true;
            }
            return false;
        }

        public bool IsHit(Point point)
        {
            List<Point> tempList = getCurrent();

            foreach (Point p in tempList)
            {
                if (p.IsHit(point))
                    return true;
            }
            return false;
        }

    }
}
