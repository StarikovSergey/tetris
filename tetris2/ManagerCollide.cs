using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tetris2
{
    class ManagerCollide
    {
        public bool Collide(Figure f1, Figure f2)
        {
            List<Point> pList1 = f1.GetCurrent();
            List<Point> pList2 = f2.GetCurrent();

            foreach (Point pf1 in pList1)
            {
                foreach (Point pf2 in pList2)
                {
                    if (pf1.x == pf2.x && pf1.y == pf2.y)
                    {
                        return true;
                    }

                }
            }
            return false;
        }
    }
}
