using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(120, 30);

            // Отрисовка рамочки
            HorizontalLine hTopLine = new HorizontalLine(0, 110, 0, '*');

            HorizontalLine hBottomLine = new HorizontalLine(0, 110, 28, '*');

            VerticalLine vLeftLine = new VerticalLine(0, 28, 0, '*');

            VerticalLine vRightLine = new VerticalLine(0, 28, 110, '*');

            hTopLine.Draw();
            hBottomLine.Draw();
            vLeftLine.Draw();
            vRightLine.Draw();

            // Отрисовка точек
            Point p = new Point(4, 5, '*');

            Snake snake = new Snake(p, 4, Direction.RIGHT);

            snake.Draw();

            Console.ReadLine();
        }
    }
}