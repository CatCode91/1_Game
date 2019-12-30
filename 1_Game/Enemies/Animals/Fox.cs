using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game.Enemies.Animals.ForestAnimals
{
    class Fox : Animal
    {
        public override int DamageValue => 12;

        public override void Roar()
        {
            Console.WriteLine("Фх-ф-ф-ф!");
        }
    }
}
