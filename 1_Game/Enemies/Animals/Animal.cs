using _1_Game.Materials;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game.Enemies
{
    public abstract class Animal : Enemy
    {
        public abstract void Roar();

        public override void SetDamage(Player p)
        {
            p.GetDamage(DamageValue);
            p.SetStrench(-3);
        }
    }
}
