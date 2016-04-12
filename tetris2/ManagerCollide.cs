using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tetris2
{
    class ManagerCollide
    {
        public bool Collide(Figure f1, Figure f2) //f1 - рандомная фигура, f2 - стакан.
        {
            if (f1.IsHit(f2))
            {
                return true;
            }
            return false;

        }

    }
}
