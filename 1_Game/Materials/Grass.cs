using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game.Materials
{
    class Grass : Material
    {
        private int _dSpeed = 1;
        public override int DampingSpeed => _dSpeed;

        public override void ApplyEffects(IBody obj)
        {
            if (obj.Strench < 50)
            {
                _dSpeed = 5;
            }
        }
    }
}
