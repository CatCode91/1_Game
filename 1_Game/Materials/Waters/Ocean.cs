using _1_Game.Enemies;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game.Materials.Waters
{
    public class Ocean : Sea
    {
        public int Deep { get; }
        public List<Fish> Fishes { get; }

        protected override int CreatingWaves(Weather weather)
        {
            //задает высоту волны в зависимости от погоды
            return _wavesHeight;
        }

    }
}
