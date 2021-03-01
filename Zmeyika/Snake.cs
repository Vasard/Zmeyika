using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zmeyika
{
    class Snake : Figure
    {
        public Direction direction;

        public Snake(Point tail, int length, Direction _direction)
        {
            direction = _direction;
            pList = new List<Point>();
            for (int i = 0; i < length; i++)
            {
                Point p = new Point(tail, ConsoleColor.Red);
                p.Move(i, direction);
                pList.Add(p);
            }
        }
        internal void Move()
        {
            Random rnd = new Random();
            int i = rnd.Next(0, 10);
            
            if (direction!=Direction.PAUS)
            {
                Point tail = pList.First();
                if (i!=0)
                {
                    pList.Remove(tail);
                }
                else
                {

                }
                Point head = GetNextPoint();
                pList.Add(head);
                tail.Clear();
                head.Draw();
                
            }
        }
        public Point GetNextPoint()
        {
            Point head = pList.Last();
            Point nextPoint = new Point(head, ConsoleColor.Red);
            Point k = new Point(); //
            
            nextPoint.Move(1, direction);
            return nextPoint;
        }
        public void HandleKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
            {
                direction = Direction.LEFT;
            }
            else if (key == ConsoleKey.RightArrow)
            {
                direction = Direction.RIGHT;
            }
            else if (key == ConsoleKey.DownArrow)
            {
                direction = Direction.DOWN;
            }
            else if (key == ConsoleKey.UpArrow)
            {
                direction = Direction.UP;
            }


        }
        internal bool Eat(Point food)
        {
            Point head = GetNextPoint(); //рандомно
            if (head.IsHit(food))
            {
                food.sym = head.sym;
                pList.Add(food);
                return true;
            }
            else
            {
                return false;
            }
        }

        //internal bool kakashki(gg kakashki)
        //{
        //    gg head = GetNextgg();
        //    if (head.IsHit(kakashki))
        //    {
        //        kakashki.sym = head.sym;
        //        gList.Add(kakashki);
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        //internal bool Eat(gg kakashki)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
