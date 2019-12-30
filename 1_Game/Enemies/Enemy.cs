using _1_Game.Field;
using _1_Game.Materials;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game.Enemies
{
    public abstract class Enemy : IBody, IMovable
    {
        public abstract int DamageValue { get; }
        
        //Point set protected, чтоб можно было переопределять метод Move в наследниках
        public Point Point { get; protected set; }

        protected  int EnemyHealth = 10;
        public int Health => EnemyHealth;

        protected int EnemyStrench = 10;
        public int Strench => EnemyStrench;

        protected int EnemyWeight = 10;
        public int Weight => EnemyWeight;

        public event MoveStateHandler Moving;
        protected void BaseClassEvent(MoveEventArgs e)
        {
           // Moving?.Invoke(this, e);
        }

        public void SetStartPosition(Point p)
        {
            Point = p;
        }

        public void SetHealth(int i)
        {
            EnemyHealth += i;
            if (EnemyHealth < 0)
            {
                EnemyHealth = 0;
            }

            if (EnemyHealth > 100)
            {
                EnemyHealth = 100;
            }
        }

        public void SetStrench(int i)
        {
            EnemyStrench -= i;
            if (EnemyStrench < 0)
            {
                EnemyStrench = 0;
            }
        }

        public void GetDamage(int i)
        {
            EnemyHealth -= i;
            if (EnemyHealth < 0)
            {
                EnemyHealth = 0;
            }

            if (EnemyHealth > 100)
            {
                EnemyHealth = 100;
            }
        }

        public virtual void SetDamage(Player p)
        {
            p.GetDamage(DamageValue);
        }

        public void Move(Vector vector, Material material)
        {
            if (material.IsMovable(this))
            {
                Point = Point + vector;
                Moving?.Invoke(this, new MoveEventArgs(Point, material.GetType().Name));
            }

            else
            {
                Moving?.Invoke(this, new MoveEventArgs(Point, $"{material.GetType()} - непроходимый материал"));
            }
        }
    }
}
