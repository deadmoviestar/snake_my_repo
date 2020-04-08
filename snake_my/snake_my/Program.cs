using System;
using System.Collections.Generic;
using System.Threading;

namespace snake_my
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(1, 1);
            Console.SetBufferSize(80, 25);
            Console.SetWindowSize(80, 25);

            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '#');
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '#');
            VerticalLine leftLine = new VerticalLine(0, 24, 0, '#');
            VerticalLine rightLine = new VerticalLine(0, 24, 78, '#');
            upLine.Draw();
            downLine.Draw();
            leftLine.Draw();
            rightLine.Draw();


            point p = new point(4,5,'*');
            Snake snake = new Snake(p, 4, Direction.right);

            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            point food = foodCreator.CreateFood();
            food.draw();

            Console.CursorVisible = false;

            while (true)
            {
                    if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.draw();
                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep(200);
                    
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.Hanlekey(key.Key);
                }
                               
            }
                     
        }
    }
}