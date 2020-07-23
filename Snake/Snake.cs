using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    /// <summary>
    /// класс змея задаем координаты хвоста, длинна, орентация
    /// </summary>
    class Snake : Figure
    {
        public Snake(Point tail, int lenght, Direction direction)
        {
            pList = new List<Point>();
            for(int i = 0; i < lenght; i++)
            {
                // создаем точки являюще. копией хвоста
                Point p = new Point(tail);
                // сдвигаем точку на i позиций по направлению
                p.move(i, direction);
                pList.Add(p);
            }
        }
    }
}
