using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game.Enemies
{
    public class Wolf : Animal
    {
        public override int DamageValue => 15;

        public override void Roar()
        {
            Console.WriteLine("Уууууууууу!");
        }
    }
}
