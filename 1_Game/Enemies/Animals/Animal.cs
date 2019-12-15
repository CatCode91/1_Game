using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game.Enemies
{
    public abstract class Animal : Enemy
    {
        public virtual int Strength { get; }

        public virtual int Speed { get; }

        public override int DamageValue => 5 * Strength;

        public override Point Point => throw new NotImplementedException();

        public abstract void Roar();

        public override void Move()
        {
            Console.WriteLine($"Бежит со скоростью: {Speed}");
        }
    }
}
