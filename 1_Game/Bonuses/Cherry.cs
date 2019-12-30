﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _1_Game.Bonuses
{
   /// <summary>
   /// Бонус вишня, увеличивает силу игрока
   /// </summary>

    public class Cherry : Bonus
    {
        private int _helpValue = 8;
        public override int HelpValue => _helpValue;

        public Cherry(Point point) : base(point)
        {
        }

        public override void ApplyBonus(Player p)
        {
            p.SetStrench(HelpValue);
        }

        protected override void ChangeBonus()
        {
            //что-то происходит с _helpValue;
          
        }
    }
}
