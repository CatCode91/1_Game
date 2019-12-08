using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game
{
    public class Player : IMovable
    {
        public Point Point { get; set; }
        public int Health { get; set; } 
        public int Strench { get; set; } 

        public event MoveStateHandler Moving;

        public void Move()
        {
            //оповестить всех подписавшихся, что игрок изменил позицию
            Moving?.Invoke(this,new MoveEventArgs("Игрок переместился!"));
            throw new NotImplementedException();
        }
    }
}
