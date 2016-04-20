using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tetris2
{
    interface Render
    {
        void Clear();
        void Draw(List<Point> pList, char sym);
        
    }
}
