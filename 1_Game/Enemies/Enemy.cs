using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game.Enemies
{
    public abstract class Enemy : IMovable
    {
        public abstract int DamageValue { get; }
        public abstract void SetDamage(Player p);

        public Point Point { get; private set; }
        public event MoveStateHandler Moving;
        protected void BaseClassEvent(MoveEventArgs e)
        {
            Moving?.Invoke(this, e);

        }

        public void Move()
        {
            Moving?.Invoke(this, new MoveEventArgs(Point));
        }

        public void SetPosition(Point point)
        {
            Point  = point;
        }
    }
}
