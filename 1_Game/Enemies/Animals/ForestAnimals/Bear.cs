using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game.Enemies.Animals.ForestAnimals
{
    class Bear : Animal
    {
        public override int Strength { get; } = 2;
        public override int Speed { get; } = 10;

        public override void Roar()
        {
            Console.WriteLine("Ррррыыыыыр!!!");
        }
    }
}
