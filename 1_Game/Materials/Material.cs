using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game.Materials
{
    public abstract class Material
    {
        public abstract int Value { get; }

        public abstract bool IsMoveble { get; } 
    }
}
