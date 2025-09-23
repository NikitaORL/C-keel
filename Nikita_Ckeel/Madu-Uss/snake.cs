using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nikita_Ckeel.Madu_Uss;

namespace Nikita_Ckeel
{
    class programm
    {
        static void Main(string[] args)
        {
            //Console.SetBufferSize(80, 25);


            // Отрисовка рамочки
            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');
            VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, 24, 78, '+');

            upLine.Draw();
            downLine.Draw();
            leftLine.Draw();
            rightLine.Draw();

            // Отрисовка точек
            Point p = new Point(4, 5, '*');
            Body_Snake snake = new Body_Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                if(snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }
                Thread.Sleep(100);
            }
        }
    }
}


//Point p1 = new Point(1, 3 , '*');
//p1.Draw();

//Point p2 = new Point(4, 5, '#');
//p2.Draw();

//HorizontalLine hline = new HorizontalLine(5,10, 8, '+');
//hline.Draw();


//Console.ReadLine();

//int x1 = 1;
//int y1 = 1;
//char sym1 = '*';

//Draw(x1, y1, sym1);

//int x2 = 4;
//int y2 = 5;
//char sym2 = '#';

//Draw(x2, y2, sym2);

