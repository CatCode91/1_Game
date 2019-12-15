using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _1_Game.Bonuses
{
    public class Apple : Bonus
    {
        private int _helpValue = 7;
        public override int HelpValue => _helpValue;

        private Point _point;
        public override Point Point => _point;

        public Apple(Point point)
        {
            _point = point;
        }

        public override void ApplyBonus(Player p)
        {
            p.SetHealth(HelpValue);
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
            while (_helpValue <= 50)
            {
                _helpValue += 4;
                await Task.Delay(5000);
            }
        }
    }
}
