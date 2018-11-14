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

        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        public void Move(int offset,Direction direction)
        {
            if (direction == Direction.Right)
            {
                x = x + offset;
            }
            else if (direction== Direction.Left)
            {
                x = x - offset;
            }
            else if (direction == Direction.Up)
            {
                y = y - offset;
            }
            else if (direction == Direction.Down)
            {
                y = y + offset;
            }
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

        public void Clear()
        {
            sym = ' ';
            Draw();
        }

        internal bool isHit(Point p)
        {
            if (p.x == x && p.y == y)
                return true;
            else return false;
        }
        //internal bool isHit2(Point p)
        //{
        //    if ((p.x+1) == x && p.y == y || (p.x-1) == x && p.y == y || (p.x) == x && (p.y + 1) == y)
        //        return true;
        //    else return false;
        //}
    }
}
