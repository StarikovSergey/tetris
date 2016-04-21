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
            Console.SetBufferSize(80, 25); //размер консоли
            RenderingConsole Render = new RenderingConsole();  //отрисовщик
            Glass glass = new Glass(); //стакан
            FigureI figureI = new FigureI();    //фигуры
            FigureJ figureJ = new FigureJ();
            FigureL figureL = new FigureL();
            FigureO figureO = new FigureO();
            FigureS figureS = new FigureS();
            FigureT figureT = new FigureT();
            FigureZ figureZ = new FigureZ();

            Figure[] arrFugures = new Figure[] { figureI, figureJ, figureL, figureO, figureS, figureT, figureZ }; //массив фигур
            Random random = new Random();  //экз. класса Random
            Figure randomFigure = arrFugures[random.Next(0, 6)];

            randomFigure.SetStartPosition();

            while (true)
            {
                ManagerCollide mc = new ManagerCollide();

                if (Console.KeyAvailable)   //проверка нажатия клавиш
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    randomFigure.HandleKey(key.Key);
                    if (key.Key == ConsoleKey.Enter)
                    {
                        if (mc.Collide(glass.GetFigureWalls(), randomFigure))
                        {
                            randomFigure.RevertRotate();
                        }
                    }
                    else if (key.Key == ConsoleKey.LeftArrow || key.Key == ConsoleKey.RightArrow)
                    {
                        if (mc.Collide(glass.GetFigureWalls(), randomFigure))
                        {
                            randomFigure.DiscardLastMove();
                        }
                    }
                }

                if (mc.Collide(glass.GetFigureBottom(), randomFigure))
                {

                    randomFigure.DiscardLastMove();
                    glass.addtoBattom(randomFigure);
                    Render.Draw(glass.GetList(), '*');     //отрисовка стакана
                    randomFigure = arrFugures[random.Next(0, 6)];
                    randomFigure.SetStartPosition();
                }
                else
                {
                    Render.Draw(glass.GetList(), '*');     //отрисовка стакана
                    Render.Draw(randomFigure.GetCurrent(), '=');   // отрисовка фигуры
                    randomFigure.moveDownPerStep();
                    Thread.Sleep(400);  //задержка
                    Render.Clear(); //очистка экрана
                }
            }
            Console.WriteLine("Game Over");
            Console.ReadKey();
        }
    }
}
