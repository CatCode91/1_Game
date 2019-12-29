using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game.Materials
{
    //трава наносящая урон игроку
    class DangerGrass : Grass
    {
        private int _damage = 5;
        public int Damage => _damage;

        public DangerGrass()
        {
            DamageChanging();
        }

        public override void ApplyEffects(IBody obj)
        {
            if (obj is Player)
            {
                obj.GetDamage(_damage);
            }
        }

        private int DamageChanging() {

            //тут какие-нибудь чудеса для изменения величины урона
            return _damage;
        }
    }
}
