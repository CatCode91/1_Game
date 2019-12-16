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
        private int _health = 70;
        public int Health => _health;

        //сила игрока
        private int _strench = 100;
        public int Strench => _strench;

        public event MoveStateHandler Moving;

        public void SetDamage(int i)
        {
            _health -= i;
            if (_health < 0)
            {
                _health = 0;
            }
        }

        public void SetHealth(int i)
        {
            _health += i;
            if (_health > 100)
            {
                _health = 100;
            }
        }

        public void SetStrench(int i)
        {
            _strench += i;
            if (_strench > 100)
            {
                _strench = 100;
            }
        }

        public void Move()
        {
            Moving?.Invoke(this, new MoveEventArgs(_point));
        }
    }
}
