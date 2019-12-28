using _1_Game.Materials;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game
{
    public interface IBody
    {
       bool IsSwimming { get; }
       void SetSpeed(int i);
    }
}
