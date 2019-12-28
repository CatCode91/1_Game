using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game.Materials
{
    public class Road : Material
    {
        public override int DampingSpeed => 0;

        public override void ApplyEffects(IBody obj)
        {
            obj.SetStrench(-1);
        }
    }
}
