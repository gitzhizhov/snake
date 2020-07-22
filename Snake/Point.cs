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
        private int x;
        private int y;
        private char symbol;

        public Point()
        {
        }

        public Point(int _x, int _y, char _symbol)
        {
            this.x = _x;
            this.y = _y;
            this.symbol = _symbol;
        }

        // рисует точку
        public void Draw()
        {
            Console.SetCursorPosition(this.x, this.y);
            Console.Write(this.symbol);
        }
    }
}
