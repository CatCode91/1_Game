using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game.Materials
{
    //обычная стена, непроходима, если объект не реализует интерфейс IFLyable
    public class Wall : Material
    {
        private string _name = "Стена";
        public override string Name => _name;

        private int _height = 55;
        public virtual int Height => _height;

        public Wall()
        {

        }

        public Wall(int height)
        {
            _height = height;
        }

        public virtual int GetDamageWall(int i)
        {
            _height -= i;

            if (_height < 10)
            {
                _name = "Стена почти разрушена!";
            }

            if (_height < 0)
            {
                _height = 0;
            }

            return _height;
        }

        public override bool IsMovable(IBody obj)
        {
            if (obj is IFlyable)
            {
                IFlyable flyable = (IFlyable)obj;

                if (flyable.FlyingHeight > _height)
                {
                    flyable.Fly();
                }
            }

            return false;
        }
    }
}
