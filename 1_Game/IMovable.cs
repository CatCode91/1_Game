﻿using _1_Game.Materials;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game
{
    public interface IMovable
    {
        Point Point { get; }
        int Speed { get; }

        void Move(Point point, Material material);
    }
}
