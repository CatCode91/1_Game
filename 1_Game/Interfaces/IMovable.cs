using _1_Game.Materials;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game
{
    public interface IMovable
    {
        Point Point { get; }

        void Move(Vector v,Material m);
    }
}
