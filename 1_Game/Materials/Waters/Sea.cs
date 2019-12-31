using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game.Materials.Waters
{
    public enum Weather
    {
        Calm,
        LightBreeze,
        Windy,
        Storm,
        PolnuyKapec
    }


    public class Sea : Water
    {
        public override string Name => "Море";

        public virtual int Size => 15;
        public override int StrenchForSwim => 15;
     
        private int _wavesHeight = 1;
        public int WavesHeight => WavesHeight;
     
        public Sea()
        {
            
        }

        public Sea(Weather weather)
        {
            CreatingWaves(weather);
        }
 
        protected virtual int CreatingWaves(Weather weather)
        {
            //задает высоту волны в зависимости от погоды
            return _wavesHeight;
        }
        
    }
}
