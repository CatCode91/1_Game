using _1_Game.Materials;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game.Enemies
{
    public class Dragon : Enemy
    {
        public override int DamageValue { get =>  10; protected set => throw new NotImplementedException(); }

        public Dragon()
        {

        }

        public Dragon(Point p) : base(p)
        {
            Point = new Point(1, 4);
        }

        public override void Move()
        {
            Point.X += 1;

            var material = GameField.CheckMaterial(Point);

            if (material is Water)
            {
                BaseClassEvent(new MoveEventArgs("Дракончик плывет", Point));
            }

            if (material is Road)
            {
                BaseClassEvent(new MoveEventArgs("Дракончик идет по дороге", Point));
            }

            if (material is Grass)
            {
                BaseClassEvent(new MoveEventArgs("Дракончик идет по траве", Point));
            }

            else
             {
                BaseClassEvent(new MoveEventArgs("Дракончик идет", Point));
             }

        }
    }
}
