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
        private int _size = 30;

        public BigApple(Point point) : base(point)
        {

        }

        public override int HelpValue => _helpValue;
        public override int Size => _size;

        protected override void ChangeBonus()
        {
            GrowApple();
        }
    }
}
