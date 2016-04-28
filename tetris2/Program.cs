using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
//using System.Timers;


namespace tetris2
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);                      //размер консоли

            Glass glass = new Glass();                          //стакан
            Game game = new Game();
            Figure[] arrF = game.CreateArrFigure();
            Figure randomFigure = game.GetRandomFigure(arrF);
            ManagerCollide mc = new ManagerCollide();

            TimeSpan timeSpan = new TimeSpan(0, 0, 0, 0, 300);

            while (true)
            {
                DateTime currentTimes = DateTime.Now;
                while (DateTime.Now < currentTimes + timeSpan)
                {
                    if (Console.KeyAvailable)   //проверка нажатия клавиш
                    {
                        ConsoleKeyInfo key = Console.ReadKey();
                        //randomFigure.HandleKey(key.Key);
                        if (key.Key == ConsoleKey.Enter)
                        {
                            randomFigure.moveRotate();
                            if (mc.Collide(glass.GetFigureWalls(), randomFigure))
                            //отмена разворота фигуры при пересечении со стенками стакана
                            {
                                randomFigure.RevertRotate();
                            }
                            else if (mc.Collide(glass.GetFigureBottom(), randomFigure))
                            //отмена разворота фигуры при пересечении со стаканом
                            {
                                randomFigure.RevertRotate();
                            }

                        }
                        else if (key.Key == ConsoleKey.LeftArrow || key.Key == ConsoleKey.RightArrow)
                        {
                            if (key.Key == ConsoleKey.LeftArrow)
                            { randomFigure.moveLeftPerStep(); }
                            else if (key.Key == ConsoleKey.RightArrow)
                            { randomFigure.moveRightPerStep(); }

                            if (mc.Collide(glass.GetFigureWalls(), randomFigure))
                            //отмена последнего действия при врезании в стену
                            {
                                randomFigure.DiscardLastMove();
                            }
                            else if (mc.Collide(glass.GetFigureBottom(), randomFigure))
                            //проверка что бы фигура не прилипала к стакану если есть возможность падать дальше
                            {
                                randomFigure.DiscardLastMove();
                            }
                        }
                    }

                    if (mc.Collide(glass.GetFigureBottom(), randomFigure))
                    //если просходит коллизия между дном стакана и фигурой
                    //фигура откатывается в предыдущую позицию, добавляется в стакан и отрисовывается.
                    //далее рандомной фируге присваевается новое значение и она устанавливается в стартовую позицию.
                    {
                        randomFigure.DiscardLastMove();
                        glass.addtoBattom(randomFigure);
                        randomFigure = game.GetRandomFigure(arrF);                      
                    }
                }
                game.Draw(glass, randomFigure);
                randomFigure.moveDownPerStep(); //движение фигуры вниз

            }

            Console.WriteLine("Game Over");
            Console.ReadKey();
        }
    }
}
