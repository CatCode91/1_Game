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
        private int _helpValue;
        public override int HelpValue => _helpValue;

        public override void ApplyBonus(Player p)
        {
            p.SetStrench(_helpValue);
            p.SetHealth(_helpValue);
        }

        protected override void ChangeBonus()
        {
            throw new NotImplementedException();
        }
    }
}
