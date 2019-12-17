using _1_Game.Field;
using _1_Game.Materials;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game.Enemies
{
    public class Dragon : Enemy
    {
        public override int DamageValue => 10;
        public bool IsFlying => true;

        public override void SetDamage(Player p)
        {
            p.SetDamage(DamageValue);
        }

        public override void Move(Point point, Material material)
        {
            if (material is Sand)
            {
                Point = point;
                BaseClassEvent(new MoveEventArgs(Point));
            }

            if (material is Water)
            {
                Point = point;
                BaseClassEvent(new MoveEventArgs(Point));
            }

            if (material is Wall)
            {
                if (material.Value > 10)
                {
                    //может перелететь
                }
            }
        }

    }
}
