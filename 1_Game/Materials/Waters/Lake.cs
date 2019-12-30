using _1_Game.Enemies;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game.Materials.Waters
{
    public class Lake : Water
    {
        public override string Name => "Озеро";
        public override int StrenchForSwim => 1;

        public bool isFishible { get; }
        public int  Deep { get; }

        public Fish Fishing()
        {
            if (isFishible)
            {
                return new Shark();
            }

            return null;
        }
    }
}
