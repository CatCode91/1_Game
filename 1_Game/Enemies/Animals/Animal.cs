using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game.Enemies
{
    public abstract class Animal : Enemy
    {
        public abstract int Strength { get; }

        public abstract int Speed { get; }

        public override int DamageValue => 5 * Strength;

        public abstract void Roar();

        public override void Move()
        {
            Console.WriteLine($"Бежит со скоростью: {Speed}");
        }
    }
}
