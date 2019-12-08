using _1_Game.Materials;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game.Enemies
{
    public class Dragon : Enemy
    {
        public override int DamageValue { get =>  10; protected set => throw new NotImplementedException(); }

        public Dragon(Point p) : base(p)
        {
           
        }

        public Dragon()
        {

        }

        public override void Move()
        {
            if (GameField.CheckMaterial(Point) is Water)
            {
                BaseClassEvent(new MoveEventArgs("Дракончик плывет", new Point(10, 10)));
            }

            if (GameField.CheckMaterial(Point) is Road)
            {
                BaseClassEvent(new MoveEventArgs("Дракончик идет по дороге", new Point(10, 10)));
            }

            if (GameField.CheckMaterial(Point) is Grass)
            {
                BaseClassEvent(new MoveEventArgs("Дракончик идет по траве", new Point(10, 10)));
            }

            else
             {
                BaseClassEvent(new MoveEventArgs("Дракончик идет", new Point(10, 10)));
             }

        }
    }
}
