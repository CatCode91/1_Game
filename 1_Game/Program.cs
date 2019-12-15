using _1_Game.Bonuses;
using _1_Game.Enemies;
using _1_Game.Enemies.Animals.ForestAnimals;
using System;

namespace _1_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Shark s = new Shark(new Point(1, 2));
            s.Move();
        }
    }
}
