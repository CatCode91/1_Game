using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game.Materials
{
    public class Water : Material
    {
        private int _speed = 0;
        public override int Speed => _speed;

        public override void TakeEffect(IBody obj)
        {
            if (obj.IsSwimming)
            {
                _speed = 1;
            }
        }
    }
}
