using _1_Game.Bonuses;
using _1_Game.Enemies;
using _1_Game.Enemies.Animals.ForestAnimals;
using _1_Game.Enemies.Fishes;
using System;

namespace _1_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Enemy bw = new BlueWhale();
            Console.WriteLine(bw.DamageValue);
            Console.ReadKey();
        }
    }
}
