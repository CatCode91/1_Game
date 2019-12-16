using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game
{
    public class Player : IMovable
    {
        public Point Point { get; }

        public int Health { get; private set; } = 100;
        public int Strench { get; private set; } = 100;

        public event MoveStateHandler Moving;

        public void SetDamage(int i)
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

        public void Move()
        {
            Moving?.Invoke(this, new MoveEventArgs(Point));
        }

    }
}
