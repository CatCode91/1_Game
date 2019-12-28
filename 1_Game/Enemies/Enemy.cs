using _1_Game.Field;
using _1_Game.Materials;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game.Enemies
{
    public abstract class Enemy
    {
        public abstract int DamageValue { get; }
        public abstract void SetDamage(Player p);

        //Point set protected, чтоб можно было переопределять метод Move в наследниках
        public Point Point { get; protected set; }
        public event MoveStateHandler Moving;
        protected void BaseClassEvent(MoveEventArgs e)
        {
           // Moving?.Invoke(this, e);
        }

        //для установки первоначальных координат
        public void SetStartPosition(Point point)
        {
            /*после установки первоначального значения, возможна установка значений Pointa только
            из метода Move
             */
            if (Point == null)
            {
                Point = point;
            }
        }

        public int GetSpeed()
        {
            throw new NotImplementedException();
        }

        public void Move(Vector v)
        {
            throw new NotImplementedException();
        }

        public void Move(Vector v, Material m)
        {
            throw new NotImplementedException();
        }
    }
}
