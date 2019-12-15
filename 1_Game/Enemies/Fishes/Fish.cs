using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game.Enemies
{
    public abstract class Fish : Enemy
    {
        private Point _point;

        protected Fish(Point point)
        {
            _point = point;
        }

        public override Point Point { get; }

        public override int DamageValue => 15;
        public override void Move()
        {
            Console.WriteLine("Рыбы плавают");
        }
    }
}
