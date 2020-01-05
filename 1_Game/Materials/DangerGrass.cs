using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game.Materials
{
    //трава наносящая урон игроку
    public class DangerGrass : Grass
    {
        private int _damage = 5;
        private int _grassHeight = 12;

        public DangerGrass()
        {
            DamageChanging();
        }

        public override string Name => "Жгучая трава";
        public override int LeavesCount => 33;
        public int Damage => _damage;
        public override int GrassHeight => _grassHeight;

        public override bool IsMovable(IBody obj)
        {
            if (obj is Player)
            {
                obj.GetDamage(Damage);
            }

            return true;
        }
        protected override int GrowGrass()
        {
            //свои условия для роста травы
            return _grassHeight;
        }
        private int DamageChanging()
        {

            //тут какие-нибудь чудеса для изменения величины урона
            return _damage;
        }

        

    }
}
