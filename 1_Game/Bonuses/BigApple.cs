using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _1_Game.Bonuses
{
    /// <summary>
    /// Бонус "Большое яблоко", увеличивает здоровье игрока и созревает быстрее обычного яблока
    /// /// </summary>
    public class BigApple : Apple
    {
        private int _helpValue = 20;
        public override int HelpValue => _helpValue;

        public BigApple(Point point) : base(point)
        {
        }

        protected override void ChangeBonus()
        {
            GrowApple();
        }

        private async void GrowApple()
        {
            while (HelpValue <= 100)
            {
                _helpValue += 1;
                await Task.Delay(3000);
            }
        }
    }
}
