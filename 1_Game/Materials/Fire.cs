﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game.Materials
{
    public class Fire : Material
    {
        public override int DampingSpeed => 1;

        private int _damageFromFire = 3;

        public override void ApplyEffects(IBody obj)
        {
            obj.GetDamage(_damageFromFire);
        }
    }
}