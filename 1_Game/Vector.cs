using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game
{
    //направление движения

    public class Vector
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public Vector(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Vector() { }

        public static Vector operator *(Vector v1, int i)
        {
            return new Vector { X = (v1.X * i), Y = (v1.Y * i) };
        }
    }
}
