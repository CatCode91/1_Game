using _1_Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game.Materials
{
    //Вода, непроходима если объект не реализует интерфейс ISwimming
    public class Water : Material
    {

        public override bool IsMovable => false;

        public override void ApplyEffects(IBody obj)
        {
            if (obj is ISwimming)
            {
                ISwimming swimming = (ISwimming)obj;
                swimming.Swim();             
            }
        }
    }
}
