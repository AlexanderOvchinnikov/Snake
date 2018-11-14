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
            Walls walls = new Walls(79, 79);
            walls.Draw();
            int count = 0;

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.Right);
            snake.DrawF();

            FoodCreator foodCreator = new FoodCreator(70, 20, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();
            
            while (true)
            {
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    Console.Clear();
                    Console.WriteLine("Конец");
                    Console.WriteLine("Вы съели "+ count + " знаков");
                    Console.ReadLine();
                    break;
                }
                if (snake.Eat(food) )
                {
                    count = count+1;
                    Console.ForegroundColor = ConsoleColor.Red;
                    food = foodCreator.CreateFood();
                    food.Draw();
                    
                    
                    
                }
                else
                {
                    snake.Move();
                }

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }

                Thread.Sleep(400);
            }


            


        }


    }
}
