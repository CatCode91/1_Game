using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game.Materials.Waters
{
    public class Sea : Water
    {
        private int _wavesHeight = 1;

        public Sea()
        {
            
        }

        public Sea(Weather weather)
        {
            CreatingWaves(weather);
        }

        public enum Weather
        {
            Calm,
            LightBreeze,
            Windy,
            Storm,
            PolnuyKapec
        }

        public override string Name => "Море";
        public virtual int Size => 15;
        public override int StrenchForSwim => 15;
        public int WavesHeight => _wavesHeight;

        protected virtual int CreatingWaves(Weather weather)
        {
            //задает высоту волны в зависимости от погоды
            return _wavesHeight;
        }      
    }
}
