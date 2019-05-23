using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.SetBufferSize(120, 30);
            Console.CursorVisible = false;

            Walls walls = new Walls(80, 25);
            walls.Draw();
            

            // Отрисовка точек
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            FoodCreator FoodCreator = new FoodCreator(80, 25, '$');
            Point food = FoodCreator.CreateFood();
            food.Draw();

            while(true)
            {
                if (walls.isHit(snake)|| snake.IsHitTail())
                {
                    break;
                }
                if (snake.Eat(food))
                {
                    food = FoodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                        }
                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
                /*Thread.Sleep(100);
                snake.Move();
            }*/
            //Console.ReadLine();
            
            }
        }
    }
}
