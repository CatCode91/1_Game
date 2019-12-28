using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game.Bonuses
{
    /// <summary>
    /// Персик, восстанавливает силу и здоровье игрока
    /// </summary>
    public class Peach : Bonus
    {
        private int _helpValue = 7;

        public Peach(Point point) : base(point)
        {
        }

        public override int HelpValue => _helpValue;

        public override void ApplyBonus(Player p)
        {
            p.SetStrench(HelpValue);
            p.SetHealth(HelpValue);
        }

        protected override void ChangeBonus()
        {
        }
    }
}
