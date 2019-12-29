using System;
using System.Collections.Generic;
using System.Text;
using _1_Game.Materials;

namespace _1_Game
{
    public class Player : IMovable, IBody
    {
        public int Health { get; private set; } = 100;
        public int Strench { get; private set; } = 100;
        public int Speed { get; private set; } = 10;
        public int Weight { get; private set; } = 7;

        public Point Point { get; private set; } = new Point();

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

        public void Move(Vector vector, Material material)
        {
            material.ApplyEffects(this);

            if (material.IsMovable)
            {
                Point = Point + vector;
                Moving?.Invoke(this, new MoveEventArgs(Point, Health, material.GetType().Name));
            }
            else
            {
                Moving?.Invoke(this, new MoveEventArgs($"{material.GetType()} - непроходимый материал"));
            }
        }
    }
}
