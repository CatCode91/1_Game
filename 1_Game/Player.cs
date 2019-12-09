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
            Point = new Point(1,1);

            var material = GameField.CheckMaterial(Point);

            if (material is Water)
            {
                this.Health += material.Value;
                Moving?.Invoke(this, new MoveEventArgs("Не могу плавать, но вода увеличила здоровье!", Point));
            }

            if (material is Road)
            {
                Moving?.Invoke(this, new MoveEventArgs("Нахожусь на дороге", Point));
            }

            if (material is Grass)
            {
                Moving?.Invoke(this, new MoveEventArgs("Нахожусь на траве", Point));
            }

            else
            {
            }
        }
    }
}
