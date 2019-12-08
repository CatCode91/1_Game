using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game.Enemies
{
    public class Wolf : Enemy
    {
        public override int DamageValue { get => 15; protected set => throw new NotImplementedException(); }

        public Wolf()
        {

        }

        public Wolf(Point p) : base(p)
        {
           
        }

        public override void Move()
        {
            BaseClassEvent(new MoveEventArgs("Волчок перемещается", new Point(10, 10)));
        }
    }
}
