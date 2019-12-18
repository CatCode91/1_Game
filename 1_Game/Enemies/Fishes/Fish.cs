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
            p.SetDamage(DamageValue);
        }

        public override void Move(Point point, Material material)
        {
            //может передвигаться только в воде

            if (material is Water)
            {
                Point = point;
                BaseClassEvent(new MoveEventArgs(Point));
            }
        }

    }
}
