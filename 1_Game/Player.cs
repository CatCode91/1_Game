using _1_Game.Materials;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game
{
    public class Player : IMovable
    {
        private Point _point;
        public Point Point { get => _point; }

        //здоровье игрока
        private int health = 100;
        public int Health {get;}

        //сила игрока
        private int strench = 100;
        public int Strench { get; }

        public event MoveStateHandler Moving;

        public Player(Point point)
        {
            _point = point;
        }

        public void SetDamage(int i)
        {
            health -= i;
            if (health < 0)
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
            Moving?.Invoke(this, new MoveEventArgs(_point));
        }
    }
}
