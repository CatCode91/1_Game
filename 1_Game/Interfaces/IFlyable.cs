using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game
{
    public interface IFlyable
    {
        int FlyingHeight { get; }

        void Fly();
    }
}
