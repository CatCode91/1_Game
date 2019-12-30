using _1_Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game.Materials
{
    //Вода, непроходима если объект не реализует интерфейс ISwimming
    public class Water : Material
    {
        public override string Name => "Вода";

        public virtual int StrenchForSwim => 12;

        public override bool IsMovable(IBody obj)
        {
            if (obj is ISwimming)
            {
                ISwimming swimming = (ISwimming)obj;
                obj.SetStrench(StrenchForSwim);
                swimming.Swim();
            }

            return false;
        }
    }
}
