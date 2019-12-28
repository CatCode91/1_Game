using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game.Materials
{
    public class Wall : Material
    {
        private int _dSpeed;
        public override int DampingSpeed => _dSpeed ;

        protected virtual int Height => 10;

        public override void ApplyEffects(IBody obj)
        {
            _dSpeed = obj.Speed;

            if (obj is IFlyable)
            {
                IFlyable flyable = (IFlyable)obj;

                if (flyable.FlyingHeight > Height)
                {
                    _dSpeed -= obj.Speed + 10;
                }
            }
        }
    }
}
