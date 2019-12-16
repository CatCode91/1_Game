using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game.Enemies
{
    public abstract class Enemy : IMovable
    {
        public abstract int DamageValue { get; }

        private Point _point;
        public virtual Point Point => _point;

        public event MoveStateHandler Moving;

        protected void BaseClassEvent(MoveEventArgs e)
        {
            Moving?.Invoke(this, e);

        }

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
