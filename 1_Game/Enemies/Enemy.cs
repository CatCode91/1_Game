using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game.Enemies
{
    public abstract class Enemy : IMovable
    {
        public abstract int DamageValue { get; }
        public abstract void SetDamage(Player p);

        private Point point;
        public virtual Point Point { get; }
        public event MoveStateHandler Moving;
        protected void BaseClassEvent(MoveEventArgs e)
        {
            Moving?.Invoke(this, e);

        }

        public virtual void Move()
        {
            throw new NotImplementedException();
        }

   


    }
}
