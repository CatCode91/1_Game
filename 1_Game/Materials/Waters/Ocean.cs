using _1_Game.Bonuses;
using _1_Game.Enemies;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game.Materials.Waters
{
    public class Ocean : Sea
    {
        private Bonus _bonus = new Apple(new Point());

        public override string Name => "Океан";
        public override int StrenchForSwim => 15;
        public int Deep { get; } = 80;
        public Bonus SecretBonus  => _bonus;
     
        protected virtual void ChangeBonus()
        {
            //изменить бонус в клетке
        }
    }
}
