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

            Console.SetBufferSize(80, 80);            
            HorizontalLine Hline = new HorizontalLine(0, 79, 1, '+');
            HorizontalLine Hline2 = new HorizontalLine(1, 79, 24, '+');
            VerticalLine Vline = new VerticalLine(0, 1, 24, '+');
            VerticalLine Vline2 = new VerticalLine(79, 1, 24, '+');
            Vline.DrawF();
            Hline2.DrawF();
            Hline.DrawF();
            Vline2.DrawF();

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.Right);
            snake.DrawF();
            
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
                Thread.Sleep(100);
                snake.Move();
            }


            Console.ReadLine();


        }


    }
}
