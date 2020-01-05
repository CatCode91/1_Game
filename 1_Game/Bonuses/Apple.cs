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
        private int _size = 30;

        public Apple(Point point) : base(point)
        {

        }

        public override int HelpValue => _helpValue;
        public virtual int Size => _size;

        public override void ApplyBonus(Player p)
        {
            p.SetHealth(HelpValue);
        }
        protected override void ChangeBonus()
        {
            GrowApple();
        }
        protected async void GrowApple()
        {
            while (HelpValue <= 50)
            {
                _size++;
                _helpValue += 4;
                await Task.Delay(5000);
            }
        }
    }
}
