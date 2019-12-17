using _1_Game.Field;
using _1_Game.Materials;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game.Enemies
{
    public abstract class Enemy : IMovable
    {
        public abstract int DamageValue { get; }
        public abstract void SetDamage(Player p);

        public Point Point { get; protected set; }
        public event MoveStateHandler Moving;
        protected void BaseClassEvent(MoveEventArgs e)
        {
            Moving?.Invoke(this, e);

        }

        public virtual void Move(Point point, Material material)
        {
            if (material is Sand)
            {
                this.Point = point;
                Moving?.Invoke(this, new MoveEventArgs(Point));
            }
        }

        public void SetPosition(Point point)
        {
            Point  = point;
        }
    }
}
