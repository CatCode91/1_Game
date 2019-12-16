using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game.Enemies
{
    public class Fish : Enemy
    {
        private Point _point;
        public override Point Point => _point;

        public override int DamageValue => 15;
        public bool CanSwim { get; } = true;
        public virtual int SwimSpeed => 10;

        public override void Move()
        {
            Console.WriteLine("Рыбы плавают");
        }

        public override void SetDamage(Player p)
        {
           
        }
    }
}
