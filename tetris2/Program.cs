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
            RenderingConsole Render = new RenderingConsole();  //отрисовщик
            Glass glass = new Glass(); //стакан
            FLine line = new FLine();  //фигура
            line.SetStartPosition();


            while (true)
            {
                ManagerCollide mc = new ManagerCollide();

                if (Console.KeyAvailable)   //проверка нажатия клавиш
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    line.HandleKey(key.Key);
                    if (key.Key == ConsoleKey.Enter)
                    {
                        if (mc.Collide(glass.GetFigureWalls(), line))
                        {
                            line.RevertRotate();
                        }
                    }
                    else if (key.Key == ConsoleKey.LeftArrow || key.Key == ConsoleKey.RightArrow)
                    {
                        if (mc.Collide(glass.GetFigureWalls(), line))
                        {
                            line.DiscardLastMove();
                        }
                    }
                }

                if (mc.Collide(glass.GetFigureBottom(), line))
                {
                    line.DiscardLastMove();
                    glass.addtoBattom(line);
                    Render.Draw(glass.GetList(), '*');     //отрисовка стакана
                    line.SetStartPosition();
                }
                else
                {
                    Render.Draw(glass.GetList(), '*');     //отрисовка стакана
                    Render.Draw(line.getCurrent(), '=');   // отрисовка фигуры
                    line.moveDownPerStep();
                    Thread.Sleep(100);  //задержка
                    Render.Clear(); //очистка экрана
                }
            }
            Console.WriteLine("Game Over");
            Console.ReadKey();
        }
    }
}
