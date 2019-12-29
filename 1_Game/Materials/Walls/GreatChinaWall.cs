using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game.Materials.Walls
{
    //Великая китайская стена, непроходима и непролетаема, нужно договариватся
    public class GreatChinaWall : Wall
    {
        private bool dogovor = false;
        public bool Dogovor { get; }

        public override void ApplyEffects(IBody obj)
        {
            //если не китаец, то полюбому IsMovable = false;
            Movable = false;
            //но если договорится то...
            if (dogovor)
            {
                Movable = true;
            }
        }

        public bool PokumekatWithKitajec(object conditions)
        {
            //тут оговариваются условия для прохождения китайской стены
            return dogovor;
        }

    }
}
