using System;
using System.Collections.Generic;
using System.Text;
using _1_Game.Materials;

namespace _1_Game
{
    public class Player : IMovable, IBody
    {
        public Point Point { get; private set; } = new Point();

        public int Health { get; private set; } = 100;
        public int Strench { get; private set; } = 100;
        public int Speed { get; private set; } = 50;

        public bool IsSwimming => false;

        public event MoveStateHandler Moving;


        public void SetSpeed(int i)
        {
            Speed += i;
            if (Speed < 0)
            {
                Speed = 0;
            }
            if (Speed > 10)
            {
                Speed = 10;
            }
        }

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

        public void Move(Vector v, Material m)
        {
            m.TakeEffect(this);
            Point = Point + (v * m.Speed);
            Moving?.Invoke(this, new MoveEventArgs(Point,Health));
        }

        public int GetSpeed()
        {
            throw new NotImplementedException();
        }

        public Point GetPoint()
        {
            throw new NotImplementedException();
        }

    }
}
