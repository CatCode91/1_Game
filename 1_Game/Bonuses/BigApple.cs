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

        private int _size = 30;
        public override int Size => _size;

        public BigApple(Point point) : base(point)
        {
           
        }

        protected override void ChangeBonus()
        {
            GrowApple();
        }

    }
}
