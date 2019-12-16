using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game.Enemies
{
    public class Animal : Enemy
    {
        public virtual int Strength { get; }

        public virtual int Speed { get; }

        public override int DamageValue => 5 * Strength;

        public virtual void Roar()
        {
            Console.WriteLine("Рррр");
        }

        public override void SetDamage(Player p)
        {
            p.SetDamage(DamageValue);
            p.SetStrench(-3);
        }
    }
}
