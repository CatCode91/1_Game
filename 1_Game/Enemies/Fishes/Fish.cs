using _1_Game.Materials;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game.Enemies
{
    public class Fish : Enemy
    {
        public override int DamageValue => 15;
        public bool CanSwim { get; } = true;
        public virtual int SwimSpeed => 10;

        public override void SetDamage(Player p)
        {
            p.SetDamage(DamageValue);
        }

        public override void Move(Point point, Material material)
        {
            if (material is Water)
            {
                Point = point;
                BaseClassEvent(new MoveEventArgs(Point));
            }
        }

    }
}
