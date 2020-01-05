using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game.Bonuses
{
    public abstract class Bonus
    {
        public Bonus(Point point)
        {
            Point = point;
            ChangeBonus();
        }

        public abstract int HelpValue { get; }
        public Point Point { get; }
       
        /// <summary>Применение бонуса к игроку</summary>
        public abstract void ApplyBonus(Player p);
        /// <summary>Используйте для изменения свойства у бонуса</summary>
        protected abstract void ChangeBonus();
    }
}
