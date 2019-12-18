using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game.Enemies.Fishes
{
    /// <summary>
    /// Класс доброй акулы, не добивает, если здоровье меньше 10 :)
    /// </summary>
    public class SharkKind : Shark
    {
        public override void SetDamage(Player p)
        {
            if (p.Health <= 10)
            {
                Console.WriteLine("Ладно, еще увидимся! :)");
            }

            else
            {
                p.SetHealth(DamageValue);
            }
        }
    }
}
