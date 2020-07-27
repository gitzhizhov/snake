﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

            //// создаем линии
            //HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
            //HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');
            //VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');
            //VerticalLine rightLine = new VerticalLine(0, 24, 78, '+');
            //// рисуем линии
            //upLine.Draw();
            //downLine.Draw();
            //leftLine.Draw();
            //rightLine.Draw();

            // создаем стены
            Walls walls = new Walls(80, 25);
            walls.Draw();

            // создаем точку в координатах
            Point p = new Point(4, 5, '*');
            // выводим на экран
            //p.Draw();
            // создаем змею по координатам точки
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while(true)
            {
                // проверка на столкновение со стенкой и с собственным хвостом
                if (walls.IsHit(snake) || snake.IsHitTail())
                    break;

                // змейка кушает
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep(200);

                // проверка на нажатие какой либо клавиши
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandlKey(key.Key);
                }
            }

            WriteGameOver();
            Console.ReadKey();
        }

        // вывод надписи окончания игры
        static void WriteGameOver()
        {
            int xOffset = 25;
            int yOffset = 8;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(xOffset, yOffset++);
            WriteText("============================", xOffset, yOffset++);
            WriteText("И Г Р А    О К О Н Ч Е Н А", xOffset + 1, yOffset++);
            WriteText("============================", xOffset, yOffset++);
        }
        static void WriteText(String text, int xOffset, int yOffset)
        {
            Console.SetCursorPosition(xOffset, yOffset);
            Console.Write(text);
        }
    }
}
