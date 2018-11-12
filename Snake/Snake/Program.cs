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
            Point p1 = new Point(1,3,'*');
            Point p2 = new Point(4,5,'#');
            Point p3 = new Point(7,14,'%');
            Point p4 = new Point(21, 4, '&');

            HorizontalLine Hline = new HorizontalLine(5, 15, 8, '+');
            Hline.Draw();
            VerticalLine Vline = new VerticalLine(4, 12, 10, '&');
            Vline.Draw();


            Console.ReadLine();

        }


    }
}
