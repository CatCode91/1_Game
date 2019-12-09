using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game
{
    //класс описывающий координаты
    public class Point
    {
        private int x;
        public int X {
            get
            {
                return x;
            }
            set
            {
                if (x < 0)
                    x = 0;

                if (x > GameField.FieldHeight)
                    x = GameField.FieldHeight;
            }
        }

        private int y;
        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                if (y < 0)
                    y = 0;
                if (y > GameField.FieldWidth)
                    y = GameField.FieldWidth;
            }
        }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
