using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<char> symbolsList = new List<char>();

            //symbolsList.Add('*');
            //symbolsList.Add('#');
            //symbolsList.Add('&');
            //symbolsList.Add('$');

            //указываем размер окна
            Console.SetBufferSize(80, 25);

            // создаем линии
            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');
            VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, 24, 78, '+');
            // рисуем линии
            upLine.Draw();
            downLine.Draw();
            leftLine.Draw();
            rightLine.Draw();


            // создаем точку в координатах
            Point p = new Point(4, 5, '*');
            // выводим на экран
            //p.Draw();
            // создаем змею
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            Console.ReadKey();
        }
    }
}
