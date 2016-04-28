using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tetris2
{
    class RenderingConsole : Render
    {
        public void Clear()
        {
            Console.Clear();
        }

        public void Draw(List<Point> pList, char sym)
        {
            foreach (Point p in pList)
            {
                Console.SetCursorPosition(p.x, p.y);
                Console.Write(sym);
            }
            
        }

        public void Draww()
        {
            Console.Write("ujk");
            Console.ReadKey();
        }
    }
}
