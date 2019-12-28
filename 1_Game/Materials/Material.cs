﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game.Materials
{
    public abstract class Material
    {
        public abstract int DampingSpeed { get; }

        public abstract void ApplyEffects(IBody obj);
    }
}
