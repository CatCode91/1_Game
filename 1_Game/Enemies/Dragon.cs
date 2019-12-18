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
            if (material is Water)
            {
                //не может плыть
                return;
            }

            if (material is Wall)
            {
                var m = (Wall)material;
                if (m.Height > 10)
                {
                    //может перелететь
                    Point = point;
                    BaseClassEvent(new MoveEventArgs(Point));
                    return;
                }
            }

            else 
            {
                Point = point;
                BaseClassEvent(new MoveEventArgs(Point));
            }
        }

    }
}
