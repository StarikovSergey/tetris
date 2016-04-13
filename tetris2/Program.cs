using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace tetris2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);
            FLine line = new FLine();
            //line.DrawFigure('X');
            Glass bottom = new Glass(Console.BufferHeight-1);
            Glass walls = new Glass(0, 79);

            bottom.DrawFigure('#');
            walls.DrawFigure('X');

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    line.HandleKey(key.Key);
                }
                ManagerCollide mc = new ManagerCollide();
                if ( mc.Collide(bottom,line))
                {
                    break;
                }
                else
                {
                    line.moveDownPerStep();
                    line.DrawFigure('X');
                }
                Thread.Sleep(1000);

                //if (Console.KeyAvailable)
                //{
                //    ConsoleKeyInfo key = Console.ReadKey();
                //    line.HandleKey(key.Key);
                //}
            }
            Console.WriteLine("Game Over");
            Console.ReadKey();
        }
    }
}
