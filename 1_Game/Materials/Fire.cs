using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game.Materials
{
    public class Fire : Material
    {
        public override bool IsMovable => true;
        private int _damageFromFire = 3;

        public Fire()
        {
            DamageChanging();
        }

        //можно задавать первоначальный урон от огня
        public Fire(int damageFromFire)
        {
            _damageFromFire = damageFromFire;
            DamageChanging();
        }

        public override void ApplyEffects(IBody obj)
        {
            obj.GetDamage(_damageFromFire);
        }

        private int DamageChanging()
        {
            //тут какие-нибудь чудеса для изменения величины урона от огня
            return  _damageFromFire = 3;
        }
    }
}
