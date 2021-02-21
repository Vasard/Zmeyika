using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zmeyika
{
    class VerticalLine : Figure
    {
        

        public VerticalLine(int yUp, int yDown, int x, char sym)//конструктор, 
            //передаёт несколько параметров 
            //yUp-координата верхней точки по y
            //yDown-координата нижней точки по y
            //x-координата по оси x
            //sym-символ
        {
            pList = new List<Point>();
            for(int y=yUp; y<=yDown; y++) 
            {
                Point p = new Point(x, y, sym); //в цикле создаём несколько точек
                pList.Add(p); //добавляем их в список
            }
        }

        
    }
}
