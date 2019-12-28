using _1_Game.Enemies.Animals.ForestAnimals;
using _1_Game.Materials;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game.Enemies.Animals
{
    //как обычный медведь, только умеет плавать
    public class WhiteBear : Bear
    {
        public override void Roar()
        {
            Console.WriteLine("Рррыыыр! Я белый медведь!!");
        }

       
    }
}
