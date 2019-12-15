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

        private Point _point;
        public override Point Point => _point;

        public Cherry(Point point)
        {
            _point = point;
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
