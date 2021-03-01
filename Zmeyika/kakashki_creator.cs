using System;
using System.Collections.Generic;
using System.Text;

namespace Zmeyika
{
    class kakashki_creator
    {
        int mapW;
        int mapH;
        char sym;
        ConsoleColor color;
        Random rand = new Random();
        public kakashki_creator(int mapW, int mapH, char sym, ConsoleColor color_)
        {
            this.mapW = mapW;
            this.mapH = mapH;
            this.sym = sym;
            color = color_;
        }
        public gg CreateKakashki()
        {
            int x = rand.Next(2, mapH - 2);
            int y = rand.Next(2, mapH - 2);
            return new gg(x, y, sym, color);
        }
    }
}
