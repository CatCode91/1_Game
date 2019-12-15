using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game.Enemies
{
    public class Wolf : Animal
    {
        private int _damageValue = 10;
        public override int DamageValue => _damageValue;

        public override void Move()
        {
            BaseClassEvent(new MoveEventArgs("Волчок перемещается", new Point(10, 10)));
        }

        public override void Roar()
        {
            Console.WriteLine("Уууууууууу!");
        }
    }
}
