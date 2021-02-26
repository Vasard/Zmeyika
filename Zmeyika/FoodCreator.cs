using System;
using System.Collections.Generic;
using System.Text;

namespace Zmeyika
{
    class FoodCreator//класс для создания еды
    {
        int mapW;
        int mapH;
        char sym;
        ConsoleColor color;
        Random rand = new Random();
        public FoodCreator(int mapW, int mapH, char sym, ConsoleColor color_)
        {
            this.mapW = mapW;
            this.mapH = mapH;
            this.sym = sym;
            color = color_;
        }
        public Point CreateFood()
        {
            int x = rand.Next(2, mapH - 2);
            int y = rand.Next(2, mapH - 2);
            return new Point(x, y, sym, color);
        }
    }
}
