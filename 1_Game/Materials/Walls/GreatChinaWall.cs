using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game.Materials.Walls
{
    //Великая китайская стена, непроходима и непролетаема, нужно договариватся
    public class GreatChinaWall : Wall
    {
        private string _name = "Великая китайская стена!";
        public override string Name => _name;

        private int _height = 100;
        public override int Height => _height;

        private bool dogovor = false;
        public bool Dogovor => dogovor;

        public bool PokumekatWithKitajec(object conditions)
        {
            //тут оговариваются условия для прохождения китайской стены
            return dogovor;
        }

        public override int GetDamageWall(int i)
        {
            _height -= i;

            if (_height < 10)
            {
                _name = "не такая уже она и великая эта стена!";
            }

            if (_height < 0)
            {
                _height = 0;
            }

            return _height;
        }

        public override bool IsMovable(IBody obj)
        {
            // если договорится то можно пройти
            if (dogovor)
            {
                return true;
            }
            return false;
        }
    }
}
