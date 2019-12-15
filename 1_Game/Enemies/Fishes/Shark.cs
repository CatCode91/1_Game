﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game.Enemies
{
    public class Shark : Fish
    {
        public Shark(Point point) : base(point)
        {

        }

        public override int DamageValue => 25;

        public override void SetDamage(Player p)
        {
            if (p.Health < 10)
            {
                Console.WriteLine("Я добрая акула! :)");
            }
            else
            {
                p.SetDamage(DamageValue);
            }
        }
    }
}
