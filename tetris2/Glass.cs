﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tetris2
{
    class Glass
    {
        protected Figure walls;
        protected Figure bottom;


        public Glass()
        {
            walls = new Figure(GetWalls(0, 39,24));
            bottom = new Figure(GetBottom(24));

        }

        public List<Point> GetWalls(int xLeft, int xRight, int y)
        {
            List<Point> pList = new List<Point>();

            for (int i = 4; i < y; i++)
            {
                Point p = new Point(xLeft, i);
                pList.Add(p);
            }

            for (int i = 4; i < y; i++)
            {
                Point p = new Point(xRight, i);
                pList.Add(p);
            }
            return pList;
        }

        public List<Point> GetBottom(int y)
        {
            List<Point> pList = new List<Point>();

            for (int i = 0; i < 40; i++)
            {
                Point p = new Point(i, y);
                pList.Add(p);
            }
            return pList;
        }

        public Figure GetFigureBottom()
        {
            return bottom;
        }

        public Figure GetFigureWalls()
        {
            return walls;
        }

        public List<Point> GetList()
        {
            List<Point> pList = new List<Point>();
            pList.AddRange(bottom.GetCurrent());
            pList.AddRange(walls.GetCurrent());
            return pList;
        }

        public void addtoBattom(Figure f)
        /*если в момент соприсокновения стакана с фигурой нажать <- , ->  или вниз
        - фигура не добавляется в стакан, а исчезает.
        так же если зажать одну из клавишь управления происходит залипание , 
        фигура становиться не управляемой и так же не добавляется в стакан, а исчезает.*/
        {
            List<Point> pList = bottom.GetCurrent();
            List<Point> fList = f.GetCurrent();

            pList.AddRange(fList);
            bottom.SetList(pList);

        }

    }
}
