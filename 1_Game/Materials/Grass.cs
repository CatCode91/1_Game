using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game.Materials
{
    class Grass : Material
    {
        private bool _isMovable = false;
        public override bool IsMovable => _isMovable;

        private int _grassHeight = 5;
        protected int GrassHeight => _grassHeight;

        public override void ApplyEffects(IBody obj)
        {
            if (obj.Strench < 50 & GrassHeight > 10)
            {
                _isMovable = true;
            }
        }

        protected virtual int GrowGrass()
        {  
            //тут что-происходит с ростом травы))
            return _grassHeight;
        }
    }
}
