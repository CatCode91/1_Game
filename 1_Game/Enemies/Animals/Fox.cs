using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game.Enemies.Animals.ForestAnimals
{
    class Fox : Animal
    {
        public override int Strength => 5;

        public override int Speed => 11;

        public override void Roar()
        {
            Console.WriteLine("Фх-ф-ф-ф!");
        }
    }
}
