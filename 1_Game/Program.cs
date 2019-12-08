using _1_Game.Bonuses;
using _1_Game.Enemies;
using System;

namespace _1_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadKey();
            Apple a = new Apple();
            Console.WriteLine(a.HelpValue);


            Dragon d = new Dragon();
            Console.WriteLine(d.DamageValue);
            d.Moving += D_Moving;
            d.Move();

            Wolf w = new Wolf();
            w.Moving += D_Moving;
            Console.WriteLine(w.DamageValue) ;
            w.Move();
            Console.WriteLine(a.HelpValue);



        }

        private static void D_Moving(object sender, MoveEventArgs e)
        {
            Console.WriteLine(sender);
            Console.WriteLine(e.Message);
   
            Console.ReadKey();
        }  
    }
}
