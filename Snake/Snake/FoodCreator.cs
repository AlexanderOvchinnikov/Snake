using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class FoodCreator : Figure
    {
        int mapWeight, mapHeight;
        char sym;

        Random random = new Random();

        public FoodCreator(int mapWeight, int mapHeight, char sym)
        {
            this.mapWeight = mapWeight;
            this.mapHeight = mapHeight;
            this.sym = sym;
        }

        public Point CreateFood()
        {
            do
            {
                int x = random.Next(2, mapWeight - 2);
                int y = random.Next(2, mapHeight - 2);
                return new Point(x, y, sym);
            }
            while (FoodUnCorrect(CreateFood()));

        }

        internal bool FoodUnCorrect(Point food)
        {
            for (int i = 0; i < pList.Count ; i++)
            {
                if (food.isHit(pList[i])) return true;
                
            }
            return false;
        }
        
         
    }
}
