using _1_Game.Materials;
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

        public Player()
        {
        }


        public void Move()
        {

            if (GameField.CheckMaterial(Point) is Water)
            {
                Moving?.Invoke(this, new MoveEventArgs("Не могу плавать!", Point));
            }

            if (GameField.CheckMaterial(Point) is Road)
            {
                Moving?.Invoke(this, new MoveEventArgs("Нахожусь на дороге", Point));
            }

            if (GameField.CheckMaterial(Point) is Grass)
            {
                Moving?.Invoke(this, new MoveEventArgs("Нахожусь на траве", Point));
            }

            else
            {
            }
        }
    }
}
