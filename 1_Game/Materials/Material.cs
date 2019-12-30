using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game.Materials
{
    public abstract class Material
    {
        public abstract string Name { get; }

        public abstract bool IsMovable(IBody obj); 
    }
}
