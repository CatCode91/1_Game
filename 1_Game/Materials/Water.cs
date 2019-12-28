using _1_Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game.Materials
{
    public class Water : Material
    {
        private int _dSpeed;
        public override int DampingSpeed => _dSpeed;

        public override void ApplyEffects(IBody obj)
        {
            _dSpeed = obj.Speed;

            if (obj is ISwimming)
            {
                ISwimming swimming = (ISwimming)obj;
                
                swimming.Swim();             
            }
        }
    }
}
