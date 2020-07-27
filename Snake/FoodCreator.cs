using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    /// <summary>
    /// класс создает еду в случайном месте на поле
    /// </summary>
    class FoodCreator
    {
        int mapWidht;
        int mapHeight;
        char symbol;

        Random rnd = new Random();

        // передаем габариты карты и символ еды
        public FoodCreator(int mapWidht, int mapHeight, char symbol)
        {
            this.mapWidht = mapWidht;
            this.mapHeight = mapHeight;
            this.symbol = symbol;
        }

        public Point CreateFood()
        {
            int x = rnd.Next(2, mapWidht - 2);
            int y = rnd.Next(2, mapHeight - 2);
            return new Point(x, y, symbol);
        }
    }
}
