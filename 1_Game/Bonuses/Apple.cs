using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _1_Game.Bonuses
{
    /// <summary>
    /// Бонус яблоко, увеличивает здоровье игрока
    /// </summary>
    public class Apple : Bonus
    {
        private int _helpValue = 7;
        public override int HelpValue => _helpValue;

        public Apple(Point point) : base(point)
        {
        }

        public override void ApplyBonus(Player p)
        {
            p.SetHealth(HelpValue);
        }

        protected override void ChangeBonus()
        {
            GrowApple();
        }

        private async void GrowApple()
        {
            while (HelpValue <= 50)
            {
                _helpValue += 4;
                await Task.Delay(5000);
            }
        }
    }
}
