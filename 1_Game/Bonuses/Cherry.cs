using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _1_Game.Bonuses
{
    public class Cherry : Bonus
    {
        private int helpValue = 10;
        public override int HelpValue
        {
            get
            {
                return helpValue;
            }

            protected set
            {
                helpValue = value;
            }
        }

        public Cherry()
        {

        }

        public Cherry(Point p) : base(p)
        {
          
        }

        public override void ApplyBonus(Player p)
        {
            p.Health += HelpValue;
        }

        protected override void ChangeBonus()
        {
            
        }

      
    }
}
