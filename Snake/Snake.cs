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
        Direction direction;

        public Snake(Point tail, int lenght, Direction _direction)
        {
            direction = _direction;
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

        // движение змейки
        internal void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add(head);

            tail.Clear();
            head.Draw();
        }

        // вычисляет где будет змейка в следующий момент
        public Point GetNextPoint()
        {
            // берем позицию головы змейки
            Point head = pList.Last();
            // создаем новую точку с координатоми головы
            Point nextPoint = new Point(head);
            // смещаем точку на 1 по направлению
            nextPoint.move(1, direction);
            // возвращаем новую точку
            return nextPoint;
        }

        // проверка на столкновение с хвостом
        internal bool IsHitTail()
        {
            var head = pList.Last();
            for (int i = 0; i < pList.Count - 2; i++)
            {
                if (head.IsHit(pList[i]))
                    return true;
            }
            return false;
        }

        // задает направление движения
        public void HandlKey(ConsoleKey key)
        {
            // какая клавиша нажата
            if (key == ConsoleKey.LeftArrow)
                direction = Direction.LEFT;
            if (key == ConsoleKey.RightArrow)
                direction = Direction.RIGHT;
            if (key == ConsoleKey.DownArrow)
                direction = Direction.DOWN;
            if (key == ConsoleKey.UpArrow)
                direction = Direction.UP;
        }

        internal bool Eat(Point food)
        {
            Point head = GetNextPoint();
            //if(head.x == food.x && head.y == food.y)
            if (head.IsHit(food))
            {
                food.symbol = head.symbol;
                pList.Add(food);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
