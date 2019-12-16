using _1_Game.Enemies.Animals.ForestAnimals;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game.Enemies.Animals
{
    public class WhiteBear : Bear
    {
        public bool CanSwim { get; } = true;

        public override void Roar()
        {
            Console.WriteLine("Рррыыыр! Я белый медведь!!");
        }
    }
}
