using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(120, 30);

            if (Console.CursorVisible == true)
            {
                Console.CursorVisible = false;
            }

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

            FoodCreator foodCreator = new FoodCreator(110, 28, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep(100);

                if (Console.KeyAvailable)
                { 
                    ConsoleKeyInfo key = Console.ReadKey(true);

                    snake.HandleKey(key.Key);
                }
            }
        }
    }
}