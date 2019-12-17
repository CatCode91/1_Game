using _1_Game.Materials;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game
{
    interface IMovable
    {
        Point Point { get; }
        void Move(Point point, Material material);
    }
}
