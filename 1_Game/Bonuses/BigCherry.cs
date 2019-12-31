﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _1_Game.Bonuses
{
    /// <summary>
    /// Бонус "Большая вишня", созревая, увеличивает больше силы игрока
    /// </summary>
    public class BigCherry : Cherry
    {
        private int _helpValue = 20;
        public override int HelpValue => _helpValue;
        public override string Color => "Бордовый";  

        public BigCherry(Point point) : base(point)
        {

        }

        protected override void ChangeBonus()
        {
            Grow();
        }

        private async void Grow()
        {
            while (HelpValue <= 100)
            {
                _helpValue += 1;
                await Task.Delay(13000);
            }
        }
    }
}

