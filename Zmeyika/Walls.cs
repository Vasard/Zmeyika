using System;
using System.Collections.Generic;
using System.Text;

namespace Zmeyika
{
    class Walls
    {
        List<Figure> wallList;

        public Walls(int mapW, int mapH)
        {
            wallList = new List<Figure>();

            HorizontalLine hUpLine = new HorizontalLine(0, mapW - 2, 0, '#');
            HorizontalLine hDownLine = new HorizontalLine(0, mapW - 2, mapH - 1, '#');
            VerticalLine vLeftLine = new VerticalLine(0, mapH - 1, 0, '#');
            VerticalLine vRightLine = new VerticalLine(0, mapH - 1, mapW - 2, '#');

            wallList.Add(hUpLine);
            wallList.Add(hDownLine);
            wallList.Add(vLeftLine);
            wallList.Add(vRightLine);
        }
        internal bool IsHit(Figure figure)
        {
            foreach (var wall in wallList)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }

        public void Draw()
        {
            foreach (var wall in wallList)
            {
                wall.Draw();
            }
        }
    }

    internal class HorizontalLine
    {
        public HorizontalLine(int v1, int v2, int v3, char v4)
        {
            V1 = v1;
            V2 = v2;
            V3 = v3;
            V4 = v4;
        }

        public int V1 { get; }
        public int V2 { get; }
        public int V3 { get; }
        public char V4 { get; }
    }
}
