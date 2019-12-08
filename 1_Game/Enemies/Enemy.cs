using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game.Enemies
{
    public abstract class Enemy : IMovable
    {
        public Point Point { get; set; }
        public int DamageValue { get; set; }
   
        private event MoveStateHandler Moving;

        protected void BaseClassEvent(MoveEventArgs e)
        {
            Moving?.Invoke(this, e);
        }

        /// <summary>Конструктор класса с координатами</summary>
        public Enemy(Point p)
        {

        }

        /// <summary> Метод, изменяющий значение свойства у объекта Игрок (наносящий урон) </summary>
        public void SetDamage(Player p)
        {
            p.Health -= DamageValue;

        }

        public virtual void Move()
        {
            throw new NotImplementedException();
        }
    }
}
