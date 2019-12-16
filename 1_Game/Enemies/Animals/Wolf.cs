using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game.Enemies
{
    public class Wolf : Animal
    {
        public override int Strength => 8;

        public override int Speed => 9;

        public override void Roar()
        {
            Console.WriteLine("Уууууууууу!");
        }
    }
}
