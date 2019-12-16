using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game.Bonuses
{
    public abstract class Bonus
    {
        public Point Point { get; }
        public abstract int HelpValue { get; }

        /// <summary>Используйте для изменения свойства у бонуса</summary>
        protected abstract void ChangeBonus();

        /// <summary>Применение значения бонуса</summary>
        public abstract void ApplyBonus(Player p);

        public Bonus()
        {
            ChangeBonus();
        }
    }
}
