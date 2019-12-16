﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game.Enemies.Fishes
{
    public class Whale : Fish
    {
        public override int SwimSpeed => 2;
        public override int DamageValue => 17;

        public override void SetDamage(Player p)
        {
            p.SetHealth(DamageValue);
            p.SetStrench(DamageValue);
        }
    }
}
