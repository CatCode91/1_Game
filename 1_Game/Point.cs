using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game
{
    //класс описывающий координаты
    public class Point
    {
        //в сетеррах валидируются значения, чтоб координаты не выходили за пределы окна
        private int _x;
        private int _y;

        public Point()
        {
            _x = 0;
            _y = 0;
        }

        public int X
        {
            get
            {
                return _x;
            }

            set
            {
                _x = value;
                if (_x > (Game.Width-1))
                {
                    _x = Game.Width-1;
                }

                if (_x < 0)
                {
                    _x = 0;
                }
            }
        }
        public int Y
        {
            get
            {
                return _y;
            }

            set
            {
                _y = value;
                if (_y > (Game.Height-1))
                {
                    _y = (Game.Height-1);
                }

                if (_y < 0)
                {
                    _y = 0;
                }
            }
        }

        #region Overridden operators

        public static Point operator +(Point p, Vector v)
        {
            return new Point {X = (p.X + v.X), Y = (p.Y + v.Y)};
        }

        public static bool operator !=(Point p1, Point p2)
        {
            bool result;
            return result = ((p1.X != p2.X) || (p1.Y != p2.Y)) ? true : false;
        }

        public static bool operator ==(Point p1, Point p2)
        {
            bool result;
            return result = ((p1.X == p2.X) & (p1.Y == p2.Y)) ? true : false;
        }

       
        public override int GetHashCode()
        {
            int hashcode = X.GetHashCode();
            hashcode = 31 * hashcode + Y.GetHashCode();
            return hashcode;
        }

        public override bool Equals(object obj) 
        {
            bool result = false;

            if (obj is Point)
            {
                Point p2 = (Point)obj;
                result = ((X == p2.X) & (Y == p2.Y)) ? true : false;
            }

            return result;
        }

        public override string ToString()
        {
            return $"X:{X.ToString()} Y:{Y.ToString()}";
        }
        #endregion
    }
}



    
   
