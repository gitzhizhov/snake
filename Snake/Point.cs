using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    /// <summary>
    /// клас описывающий точку
    /// и выводит её на экран
    /// </summary>
    class Point
    {
        public int x;
        public int y;
        public char symbol;

        public Point()
        {
        }

        public Point(int _x, int _y, char _symbol)
        {
            this.x = _x;
            this.y = _y;
            this.symbol = _symbol;
        }

        // конструктор создает точки с помощью др. точки
        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            symbol = p.symbol;
        }

        // метод движения, перемещения точки
        public void move(int offset, Direction direction)
        {
            if(direction == Direction.RIGHT)
            {
                x = x + offset;
            }

            if (direction == Direction.LEFT)
            {
                x = x - offset;
            }

            if (direction == Direction.DOWN)
            {
                y = y + offset;
            }

            if (direction == Direction.UP)
            {
                y = y - offset;
            }
        }

        // рисует точку
        public void Draw()
        {
            Console.SetCursorPosition(this.x, this.y);
            Console.Write(this.symbol);
        }

        // затираем точку
        public void Clear()
        {
            symbol = ' ';
            Draw();
        }

        public override string ToString()
        {
            return x + ", " + y + ", " + symbol;
        }

        // проверка попадания на точку с едой
        // проверка на равество координат
        // есть ли пересечение координат с текущей точкой и переданой точкой
        internal bool IsHit(Point food)
        {
            return food.x == this.x && food.y == this.y;
        }
    }
}
