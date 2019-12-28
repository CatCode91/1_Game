using _1_Game.Materials;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game.Enemies
{
    public abstract class Fish : Enemy
    {
        public bool CanSwim { get; } = true;
        public abstract int SwimSpeed { get; }

        public override void SetDamage(Player p)
        {
            p.GetDamage(DamageValue);
        }

    }
}
