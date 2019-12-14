using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _1_Game.Bonuses
{
    public class Cherry : Bonus
    {
        private int _helpValue = 8;
        public override int HelpValue => _helpValue;

        public Cherry()
        {

        }

        public Cherry(Point p) : base(p)
        {
          
        }

        public override void ApplyBonus(Player p)
        {
            p.SetStrench(HelpValue);
        }

        protected override void ChangeBonus()
        {
            
        }
    }
}
