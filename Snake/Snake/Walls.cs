using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Walls 
    {
        List<Figure> wallList;

        public Walls (int mapWeight, int mapHeight)
        {
            wallList = new List<Figure>();

            HorizontalLine Upline = new HorizontalLine(0, mapWeight - 1, 0, '+');
            HorizontalLine Downline = new HorizontalLine(0, mapWeight - 1, mapHeight, '+');
            VerticalLine Leftline = new VerticalLine(0 ,mapHeight-1, 0, '+');
            VerticalLine Rightline = new VerticalLine(0,mapHeight-1, mapWeight-1, '+');

            wallList.Add(Upline);
            wallList.Add(Downline);
            wallList.Add(Leftline);
            wallList.Add(Rightline);
        }

        internal bool IsHit(Figure figure)
        {
            foreach(var wall in wallList)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }

            }
            return false;
        }

        public void Draw()
        {
            foreach (var wall in wallList)
            {
                wall.DrawF();
            }
        }
    }
}
