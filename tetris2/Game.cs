using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tetris2
{
    class Game
    {
        Random random = new Random();
        RenderingConsole Render = new RenderingConsole();  //отрисовщик


        public Figure[] CreateArrFigure()
        {
            FigureI figureI = new FigureI();                    //фигуры
            FigureJ figureJ = new FigureJ();
            FigureL figureL = new FigureL();
            FigureO figureO = new FigureO();
            FigureS figureS = new FigureS();
            FigureT figureT = new FigureT();
            FigureZ figureZ = new FigureZ();

            Figure[] arrFigures = new Figure[] { figureI, figureJ, figureL, figureO, figureS, figureT, figureZ }; //массив фигур
            return arrFigures;
        }

        public Figure GetRandomFigure(Figure[] arrFigures)
        {
            Figure randomFigure = arrFigures[random.Next(arrFigures.Length)];
            return randomFigure;
        }

        public void Draw(Glass glass, Figure randomFigure )
        {
            Render.Clear(); //очистка экрана
            Render.Draw(glass.GetList(), '*');     //отрисовка стакана
            Render.Draw(randomFigure.GetCurrent(), '=');   // отрисовка фигуры
        }
    }
}
