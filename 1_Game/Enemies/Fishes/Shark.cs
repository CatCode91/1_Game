using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game.Enemies
{
    //Класс акулы
    public class Shark : Fish
    {
        public override int DamageValue => 5;
        public override int SwimSpeed => 25;

        public override void SetDamage(Player p)
        {
                p.SetDamage(DamageValue);
        }
    }
}
