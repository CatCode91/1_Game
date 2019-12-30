using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game.Materials
{
    public class Grass : Material
    {
        public override string Name => "Трава";

        public virtual int LeavesCount { get; } = 1;

        private int _grassHeight = 5;
        public int GrassHeight => _grassHeight;

        public override bool IsMovable(IBody obj)
        {
            if (obj.Strench < 30 | GrassHeight > 40)
            {
                return false;
            }

            return true;
        }

        protected virtual int GrowGrass()
        {  
            //тут что-происходит с ростом травы))
            return _grassHeight;
        }
    }
}
