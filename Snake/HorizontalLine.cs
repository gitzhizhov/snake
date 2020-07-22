using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontalLine
    {
        // линия набор точек
        List<Point> pList;

        public HorizontalLine(int xLeft, int xReight, int y, char sym)
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

            for(int x = xLeft; x <= xReight; x++)
            {
                // создаем точки с нужными координатами
                Point p = new Point(x, y, sym);
                // добавляем в список
                pList.Add(p);
            }
        }
        // рисуем линию
        public void Draw()
        {
            foreach(Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
