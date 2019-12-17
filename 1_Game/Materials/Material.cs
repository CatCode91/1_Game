﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game.Materials
{
    public abstract class Material
    {
        //коэффициент, который влияет на какое-нибудь свойство игрока (определяется в методе движения)
        public abstract int Value { get; }
    }
}