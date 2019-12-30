using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game.Materials.Waters
{
    public class Sea : Water
    {
        public enum Weather
        {
           Calm,
           LightBreeze,
           Windy,
           Storm,
           PolnuyKapec          
        }

        public override int StrenchForSwim => 15;
        public override string Name => "Море";

        protected int _wavesHeight = 1;
        public int WavesHeight => _wavesHeight;
     
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
