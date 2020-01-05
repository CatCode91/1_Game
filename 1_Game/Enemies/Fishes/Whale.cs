using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game.Enemies.Fishes
{
    public class Whale : Fish
    {
        public override int DamageValue => 17;
        public override int Size => 999;
        public override string Name => "Кит";
        public override string Color => "Синий";
        public override void SetDamage(Player p)
        {
            p.SetHealth(DamageValue);
            p.SetStrench(DamageValue);
        }
    }
}
