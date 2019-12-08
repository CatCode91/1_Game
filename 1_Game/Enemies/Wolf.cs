using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game.Enemies
{
    public class Wolf : Enemy
    {
        public Wolf(Point p) : base(p)
        {
            DamageValue = 15;
        }

        public override void Move()
        {
            BaseClassEvent(new MoveEventArgs("Волчок пробежал", new Point(10, 10)));
        }
    }
}
