using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _1_Game.Bonuses
{
    public class Apple : Bonus
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

        public Apple()
        {
        
        }

        public Apple(Point p) : base(p)
        {
           
        }

        public override void ApplyBonus(Player p)
        {
            p.Health += HelpValue;
        }

        protected override void ChangeBonus()
        {
            GrowApple();
        }

        /// <summary>
        /// Метод "поспевания" яблока 
        /// </summary>
        private async void GrowApple()
        {
            while (helpValue <= 50)
            {
                helpValue += 4;
                await Task.Delay(5000);
            }
        }

    }
}
