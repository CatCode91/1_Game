using _1_Game.Field;
using _1_Game.Materials;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game.Enemies
{
    public class Dragon : Enemy ,IBody, IFlyable
    {
        public override int DamageValue => 10;
        public bool IsFlying => true;

        public int FlyingHeight => 10;

        public int Health => 10;

        public int Speed => 4;

        public int Strench => 100;

        public void Fly()
        {
            throw new NotImplementedException();
        }

        public void GetDamage(int i)
        {
            throw new NotImplementedException();
        }

        public override void SetDamage(Player p)
        {
            p.GetDamage(DamageValue);
        }

        public void SetHealth(int i)
        {
            throw new NotImplementedException();
        }

        public void SetSpeed(int i)
        {
            throw new NotImplementedException();
        }

        public void SetStrench(int i)
        {
            throw new NotImplementedException();
        }
    }
}
