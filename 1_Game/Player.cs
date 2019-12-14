using _1_Game.Materials;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game
{
    public class Player : IMovable
    {
        public Point Point { get; private set; }

        private int health = 100;
        public int Health {get;}

        private int strench = 100;
        public int Strench { get; }

        public event MoveStateHandler Moving;

        public Player()
        {

        }

        public void SetDamage(int i)
        {
            health -= i;
            if (health <= 0)
            {
                health = 0;
            }
        }

        public void SetHealth(int i)
        {
            health += i;
            if (health > 100)
            {
                health = 100;
            }
        }

        public void SetStrench(int i)
        {
            strench += i;
            if (strench > 100)
            {
                strench = 100;
            }
        }

        public void Move()
        {
            Point = new Point(1,1);
        }
    }
}
