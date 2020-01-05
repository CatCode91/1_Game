using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game.Enemies
{
    //Класс акулы
    public class Shark : Fish
    {
        public override string Name => "Акула";
        public override string Color => "Белый";
        public override int Size => 123;
        public override int DamageValue => 11;
    }
}
