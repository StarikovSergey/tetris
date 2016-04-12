using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tetris2
{
    class Point
    {
        public int x;
        public int y;
        //public char sym;

        public Point()
        { }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }







        //public Point(int x, int y, char sym)
        //{
        //    this.x = x;
        //    this.y = y;
        //    this.sym = sym;
        //}
        
        //public bool IsHit(Point p)
        //{
        //    return p.x == this.x && p.y == this.y;
        //}

        //public void Draw(char sym)
        //{
        //    Console.SetCursorPosition(x, y);
        //    Console.Write(sym);
        //}

        //public void Clear()
        //{
        //    char sym = ' ';
        //    Draw(sym);
        //}
    }
}
