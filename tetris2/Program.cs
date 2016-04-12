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
            FLine line = new FLine();
            //line.DrawFigure('X');
            //FLine downLine = new FLine(0, 79, 24, '+');
            //downLine.DrawFigure('#');

            //while (true)
            //{
            //    if (downLine.IsHit(line))
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        line.moveDownPerStep();
            //        line.DrawFigure('X');
            //    }
            //    Thread.Sleep(1000);

            //    if (Console.KeyAvailable)
            //    {
            //        ConsoleKeyInfo key = Console.ReadKey();
            //        line.HandleKey(key.Key);
            //    }
            //}
            Glass glass = new Glass();
            glass.add(line);
            glass.DrawFigure('X');
            Console.ReadKey();
        }
    }
}
