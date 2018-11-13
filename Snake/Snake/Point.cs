using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        public int x, y;
        public char sym;

        public Point()
        {

        }

        public Point(int x1, int y1, char sym1)
        {
            x = x1;
            y = y1;
            sym = sym1;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }


    }
}
