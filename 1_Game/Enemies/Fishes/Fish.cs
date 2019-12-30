using _1_Game.Interfaces;
using _1_Game.Materials;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game.Enemies
{
    public abstract class Fish : Enemy, ISwimming
    {
        public abstract string Name { get; }
        public abstract string Color { get; }
        public abstract int Size { get; }

        public void Swim()
        {
            Console.WriteLine("Плыву!");
        }
    }
}
