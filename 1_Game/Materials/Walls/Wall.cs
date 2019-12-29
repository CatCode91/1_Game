using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game.Materials
{
    //обычная стена, непроходима, если объект не реализует интерфейс IFLyable
    public class Wall : Material
    {   
        protected bool Movable = false;
        public override bool IsMovable => Movable;
        private readonly int _height = 10;
        protected virtual int Height => _height;

        public Wall()
        {

        }

        public Wall(int height)
        {
            _height = height;
        }

        public override void ApplyEffects(IBody obj)
        {        
            if (obj is IFlyable)
            {
                IFlyable flyable = (IFlyable)obj;

                if (flyable.FlyingHeight > _height)
                {
                    Movable = true;
                }
            }
        }
    }
}
