using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game.Enemies
{
    public class Animal : Enemy
    {
        private int _damageValue = 10;
        public override int DamageValue => _damageValue;

    }
}
