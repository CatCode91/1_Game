using _1_Game.Bonuses;
using _1_Game.Enemies;
using _1_Game.Field;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game
{
    enum Motion
    {
        Up,
        Down,
        Left,
        Right
    }

    public class Game
    {
        Player player = new Player();
        Enemy[] enemies = new Enemy[10];
        List<Bonus> bonuses = new List<Bonus>(10);
        GameField gamefield;

        private int height;
        private int width;
   
        public Game(int h,int w)
        {
            height = h;
            width = w;

            gamefield = new GameField(height, width);
            player.Moving += Player_Moving;
            MoveController m = new MoveController(player);
        }

        private void Player_Moving(object sender, MoveEventArgs e)
        {
            PlayerCollisions(e);
            CheckGameStatus();
        }

        private void Enemy_Moving(object sender, MoveEventArgs e)
        {
            var enemy = (Enemy)sender;

            if (enemy.Point == player.Point)
            {
                enemy.SetDamage(player);
            }

            CheckGameStatus();
        }

        private void PlayerCollisions(MoveEventArgs e)
        {
            foreach (Enemy s in enemies)
            {
                if (e.Point == s.Point)
                {
                    s.SetDamage(player);
                    Console.WriteLine($"Нанесен урон {s.DamageValue}");
                }
            }

            foreach (Bonus s in bonuses)
            {
                if (e.Point == s.Point)
                {
                    s.ApplyBonus(player);
                    Console.WriteLine($"Здоровье увеличилось {s.HelpValue}");
                    bonuses.Remove(s);
                }
            }
        }

        public void CheckGameStatus()
        {
            if (player.Health <= 0)
            {
                Console.WriteLine("Вы проиграли!");
            }

            if (bonuses.Count == 0)
            {
                Console.WriteLine("Вы собрали все бонусы!");
            }
        }
    }
}
