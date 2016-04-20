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
            pList = new List<Point>();
        }

        public Figure(List<Point> pList)
        {
            currentPos = new Point();
            this.pList = pList;
        }

        public void SetList(List<Point> pList)
        {
            this.pList = pList;
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

        public void SetStartPosition()
        {
               
            setPos(20, 0);
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

        public void RevertRotate()
        {
            foreach (Point p in pList)
            {
                int tepm = p.x;
                p.x = p.y;
                p.y = -(tepm);
            }
        }

        public void DiscardLastMove()
        {
            currentPos.x = lastPos.x;
            currentPos.y = lastPos.y;
        }
    }
}
