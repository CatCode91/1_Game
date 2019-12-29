using _1_Game.Enemies;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game.Materials.Waters
{
    public class Lake : Water
    {
        public bool isFishible { get; }
        public int  Deep { get; }


        private Fish Fishing()
        {
            return new Shark();
        }
    }
}
