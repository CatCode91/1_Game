using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game.Materials
{
    public class Fire : Material
    {
        private int _timeToFire = 30;
        private int _damageFromFire = 3;

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

        public override string Name => "Огонь!";
        //урон от огня
        public int DamageFromFire => _damageFromFire;
        //время уничтожения    
        public int TimeToFire => _timeToFire;
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

        public override bool IsMovable(IBody obj)
        {
            obj.GetDamage(DamageFromFire);
            return true;
        }
        //метод изменения величины урона
        private int DamageChanging()
        {
            //тут какие-нибудь чудеса для изменения величины урона от огня
            return  _damageFromFire = 3;
        }     
    }
}
