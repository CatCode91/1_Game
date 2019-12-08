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
            Dragon d = new Dragon(new Point(1,1));
            Console.WriteLine(d.DamageValue);
            d.Moving += D_Moving;
            d.Move();

            Wolf w = new Wolf(new Point(1, 1));
            w.Moving += D_Moving;
            Console.WriteLine(w.DamageValue) ;
            w.Move();
        }

        private static void D_Moving(object sender, MoveEventArgs e)
        {
            Console.WriteLine(sender);
            Console.WriteLine(e.Message);
   
            Console.ReadKey();
        }  
    }
}
