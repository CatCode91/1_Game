using _1_Game.Field;
using _1_Game.Materials;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game.Enemies
{
    public class Dragon : Enemy,  IFlyable
    {
        public Dragon()
        {
            EnemyHealth = 100;
            EnemyStrench = 50;
            EnemyWeight = 70;
        }

        public override int DamageValue => 10;
        public int FlyingHeight => 10;

        #region IFlyable
        public void Fly()
        {
            Console.WriteLine("Лечу!");
        }
        #endregion   
    }
}
