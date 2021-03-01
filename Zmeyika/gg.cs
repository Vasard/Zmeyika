using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Zmeyika
{
    class gg
    {
        public int x;
        public int y;
        public char sym;
        public ConsoleColor color;
        public gg()
        {
        }
        public gg(int x_, int y_, char sym_, ConsoleColor color_)
        {
            x = x_;
            y = y_;
            sym = sym_;
            color = color_;
        }
        public gg(gg g, ConsoleColor color_)
        {
            x = g.x;
            y = g.y;
            sym = g.sym;
            color = color_;
        }



        public void Move(int offset, Direction direction)
        {
            if (direction == Direction.RIGHT)
            {
                x = x + offset;
            }
            else if (direction == Direction.LEFT)
            {
                x = x - offset;
            }
            else if (direction == Direction.UP)
            {
                y = y - offset;
            }
            else if (direction == Direction.DOWN)
            {
                y = y + offset;
            }
            else if (direction == Direction.PAUS)
            {
                Console.ReadKey();
            }

        }

        public void Clear()
        {
            sym = ' ';
            Draw();
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = color;
            Console.Write(sym);
        }
        public override string ToString()
        {
            return x + "," + y + "," + sym;
        }

        internal bool IsHit(gg g)
        {
            return g.x == this.x && g.y == this.y;
        }
    }
}
