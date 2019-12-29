using _1_Game.Materials;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game
{
    public interface IBody
    {
       int Health { get; }
       int Speed { get; }
       int Strench { get; }
       int Weight { get; }

       void SetStrench(int i);

       void SetHealth(int i);

       void GetDamage(int i);  
    }
}
