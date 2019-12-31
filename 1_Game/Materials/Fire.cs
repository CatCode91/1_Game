using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game.Materials
{
    public class Fire : Material
    {
        public override string Name => "Огонь!";

        //урон от огня
        private int _damageFromFire = 3;
        public int DamageFromFire => _damageFromFire;

        //время уничтожения
        private int _timeToFire = 30;
        public int TimeToFire => _timeToFire;

        public Fire()
        {
            DamageChanging();
        }

        //можно задавать первоначальный урон от огня в конструкторе
        public Fire(int damageFromFire)
        {
            _damageFromFire = damageFromFire;
            DamageChanging();
        }

        //метод сжигания материала
        public Material BurnMaterial(Material m)
        {
            while (TimeToFire > 0)
            {
                _timeToFire--;
            }
           
            m = new Ash();
            return m;
        }

        //метод изменения величины урона
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
