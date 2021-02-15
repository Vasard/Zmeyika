using System;
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
            Point p1 = new Point(1, 3, '*'); //создаём точку с некими координатами
            p1.Draw(); //выводим её на экран 
            //принцип называется инкапсуляцией. всё, что относится к точке сосредоточено в другом классе 
            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            Console.ReadLine();
        }
        
      
    }
}
