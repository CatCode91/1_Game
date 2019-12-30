using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game.Materials.Walls
{
    //Великая китайская стена, непроходима и непролетаема, нужно договариватся
    public class GreatChinaWall : Wall
    {
        private bool dogovor = false;
        public bool Dogovor => dogovor;

        public override bool IsMovable(IBody obj)
        {
            // если договорится то можно пройти
            if (dogovor)
            {
                return true;
            }
            return false;
        }

        public bool PokumekatWithKitajec(object conditions)
        {
            //тут оговариваются условия для прохождения китайской стены
            return dogovor;
        }

        public void CheckNation(object sender)
        {
            //тут должно проверится нужное свойство объекта
            if (sender.ToString() == "Китаец")
            {
                dogovor = true;
            }
        }
    }
}
