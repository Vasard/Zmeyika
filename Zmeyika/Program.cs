﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zmeyika
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25); //устанавливает размер окна 
            //и убирает возможность перемотки

            //Отрисовка рамочки
            HorizontallLine upLine = new HorizontallLine(0, 78, 0, '+');
            HorizontallLine downLine = new HorizontallLine(0, 78, 24, '+');
            VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, 24, 78, '+');
            upLine.Drow();
            downLine.Drow();
            leftLine.Drow();
            rightLine.Drow();

            //Отрисовка точек
            Point p = new Point(4, 5, '*');
            p.Draw();
        }

    }

}
