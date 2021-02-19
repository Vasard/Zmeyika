using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zmeyika
{
    class HorizontallLine
    {
        List<Point> pList;


        //создаём конструктор
        //метод, который будет называться при создании

        public HorizontallLine(int xLeft, int xRight, int y, char sym) //при создании горизонтальной линии
            //пишем параметры, которые будем задавать в ()
        {
            pList = new List<Point>();  //создаём пустой список
            //создаём цикл for
            for(int x = xLeft; x <= xRight; x++) //на каждой оперции x будет получать значение
                //начиная от xLeft заканчивая xRight
            {
                Point p = new Point(x, y, sym); //создаём точки с нужными координатами
                pList.Add(p); //добавляем в список точек
            }

        }
        //выводим на экран с помощью метода
        public void Drow ()
        {
            foreach(Point p in pList) //пробегает по всем точкам из списка
            {
                p.Draw(); //выводит их на экран
            }
        }
    }
}
