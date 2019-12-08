using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game.Enemies
{
    public class Dragon : Enemy
    {
        public Dragon(Point p) : base(p)
        {
            DamageValue = 35;
        }

        public override void Move()
        {
            BaseClassEvent(new MoveEventArgs("Дракончик переместился",new Point(10,10)));
        }
    }
}
