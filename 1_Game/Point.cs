using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game
{
    //класс описывающий координаты
    public class Point
    {
        //в сетеррах валидируются значения, чтоб координаты не выходили за пределы окна
        private int x;
        public int X
        {
            get
            {
                return x;
            }

            set
            {
                x = value;

                if (x > (Game.Width-1))
                {
                    x = Game.Width-1;
                }

                if (x < 0)
                {
                    x = 0;
                }

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
                y = value;

                if (y > (Game.Height-1))
                {
                    y = (Game.Height-1);
                }

                if (y < 0)
                {
                    y = 0;
                }

            }
        }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {

            return $"X:{X.ToString()} Y:{Y.ToString()}";
        }
    }
}



    
   