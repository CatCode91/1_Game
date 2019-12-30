using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game.Materials
{
    //трава наносящая урон игроку
    class DangerGrass : Grass
    {
        public override string Name => "Жгучая трава";
        public override int LeavesCount => 33;

        private int _damage = 5;
        public int Damage => _damage;

        public DangerGrass()
        {
            DamageChanging();
        }

        public override bool IsMovable(IBody obj)
        {
            if (obj is Player)
            {
                obj.GetDamage(Damage);
            }

            return true;
        }

        private int DamageChanging() {

            //тут какие-нибудь чудеса для изменения величины урона
            return _damage;
        }
    }
}
