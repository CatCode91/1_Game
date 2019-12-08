using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _1_Game.Bonuses
{
    public class Cherry : Bonus
    {
        public Cherry(Point p) : base(p)
        {
            HelpValue = 3;
        }

        public override void ApplyBonus(Player p)
        {
            p.Health += HelpValue;
        }

        public override void ChangeBonus()
        {
            
        }

      
    }
}
