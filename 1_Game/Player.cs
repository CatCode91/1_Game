using System;
using System.Collections.Generic;
using System.Text;
using _1_Game.Materials;

namespace _1_Game
{
    public class Player : IMovable, IBody
    {
        public Point Point { get; private set; } = new Point();
        public event MoveStateHandler Moving;

        #region IBody
        public int Health { get; private set; } = 100;
        public int Strench { get; private set; } = 100;
        public int Weight { get; private set; } = 7;
        public void GetDamage(int i)
        {
            Health -= i;
            if (Health < 0)
            {
                Health = 0;
            }
        }

        public void SetHealth(int i)
        {
            Health += i;
            if (Health > 100)
            {
                Health = 100;
            }
        }

        public void SetStrench(int i)
        {
            Strench += i;
            if (Strench > 100)
            {
                Strench = 100;
            }

            if (Strench < 0)
            {
                Strench = 0;
            }
        }
        #endregion

        #region IMovable
        public void Move(Vector vector, Material material)
        {
            if (material.IsMovable(this))
            {
                Point = Point + vector;
                Moving?.Invoke(this, new MoveEventArgs(Point, material.GetType().Name));
            }
            else
            {
                Moving?.Invoke(this, new MoveEventArgs(Point, $"{material.GetType()} - непроходимый материал"));
            }
        }
        #endregion
    }
}
