using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game.Materials
{
    public class Fire : Material
    {
        public override string Name => "Огонь!";
        private int _damageFromFire = 3;
        public int DamageFromFire => _damageFromFire;

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

        private int DamageChanging()
        {
            //тут какие-нибудь чудеса для изменения величины урона от огня
            return  _damageFromFire = 3;
        }

        public override bool IsMovable(IBody obj)
        {
            obj.GetDamage(DamageFromFire);
            return true;
        }
    }
}
