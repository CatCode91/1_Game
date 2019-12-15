using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game.Enemies
{
    public abstract class Enemy : IMovable
    {
        #region Свойства
        public abstract int DamageValue { get; }
        #endregion

        #region Cвойства и события движения
        public virtual Point Point { get; }

        public event MoveStateHandler Moving;

        protected void BaseClassEvent(MoveEventArgs e)
        {
            Moving?.Invoke(this, e);

        }
        #endregion

        public virtual void SetDamage(Player p)
        {
            p.SetDamage(DamageValue);
        }

        public virtual void Move()
        {
            throw new NotImplementedException();
        }
    }
}
