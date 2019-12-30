using _1_Game.Bonuses;
using _1_Game.Enemies;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game.Materials.Waters
{
    public class Ocean : Sea
    {
        public override string Name => "Океан";
        public override int StrenchForSwim => 15;

        public int Deep { get; } = 80;

        private Bonus _bonus;
        public Bonus SecretBonus  => _bonus;
     
        protected override int CreatingWaves(Weather weather)
        {
            //задает высоту волны в океане в зависимости от погоды
            return _wavesHeight;
        }

        protected virtual void SetBonus(Point p)
        {
            //клетка из этого материала может содержать скрытый бонус
            _bonus = new Apple(p);
        }
    }
}
