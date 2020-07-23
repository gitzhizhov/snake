using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontalLine : Figure
    {
        public HorizontalLine(int xLeft, int xRight, int y, char sym)
        {
            // создаем пустой список
            pList = new List<Point>();
            //// добавляем точки
            //Point p1 = new Point(4, 4, '*');
            //Point p2 = new Point(5, 4, '*');
            //Point p3 = new Point(6, 4, '*');
            ////добавляем в список
            //pList.Add(p1);
            //pList.Add(p2);
            //pList.Add(p3);

            for(int x = xLeft; x <= xRight; x++)
            {
                // создаем точки с нужными координатами
                Point p = new Point(x, y, sym);
                // добавляем в список
                pList.Add(p);
            }
        }
    }
}
