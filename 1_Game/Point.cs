﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game
{
    //класс описывающий координаты
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString() {

            return $"X:{X.ToString()} Y:{Y.ToString()}"; 
        }

    }
}
