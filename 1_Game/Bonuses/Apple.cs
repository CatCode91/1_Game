using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _1_Game.Bonuses
{
    public class Apple : Bonus
    {
        public Apple(Point p) : base(p)
        {
            HelpValue = 1;
        }

        public override void ApplyBonus(Player p)
        {
            p.Health += HelpValue;
        }

        public override void ChangeBonus()
        {
            GrowApple();
        }

        private async void GrowApple()
        {
            while (HelpValue <= 50)
            {
                HelpValue += 4;
                await Task.Delay(5000);
            }
        }

    }
}
