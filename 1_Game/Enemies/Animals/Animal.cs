using _1_Game.Materials;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game.Enemies
{
    public class Animal : Enemy
    {
        public virtual int Strength { get; }

        public virtual int Speed { get; }

        public override int DamageValue => 5 * Strength;

        public virtual void Roar()
        {
            Console.WriteLine("Рррр");
        }

        public override void SetDamage(Player p)
        {
            p.SetDamage(DamageValue);
            p.SetStrench(-3);
        }

        public override void Move(Point point, Material material)
        {
            if (material is Grass)
            {
                this.Point = point;
                BaseClassEvent(new MoveEventArgs(Point));
            }

            if (material is Sand)
            {
                this.Point = point;
                BaseClassEvent(new MoveEventArgs(Point));
            }
        }
    }
}
