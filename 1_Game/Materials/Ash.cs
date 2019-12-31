using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game.Materials
{
    public class Ash : Material
    {
        public override string Name => "Пепел";

        //количество угольков
        public int CoalsCount => 12;
        //время анимации (например для тления)
        public int AnimationTime = 17; 

        public override bool IsMovable(IBody obj)
        {
            return true;
        }
    }
}
