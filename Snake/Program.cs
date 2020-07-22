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
                        
            // создаем точку в координатах
            Point p1 = new Point(1, 3, '*');
            // выводим на экран
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            HorizontalLine hLine = new HorizontalLine(1,20,8,'+');
            hLine.Draw();
            VerticalLine vLine = new VerticalLine(9, 20, 1, '+');
            vLine.Draw();

            Console.ReadKey();
        }
    }
}
