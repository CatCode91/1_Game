using _1_Game.Bonuses;
using _1_Game.Enemies;
using _1_Game.Field;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game
{
    public class Game
    {
        Player player;
        Enemy[] enemies;
        List<Bonus> bonuses;
        GameField gamefield;
   
        public Game()
        {
            gamefield = new GameField(1000, 600);
            player = new Player();
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

        private void Player_Moving(object sender, MoveEventArgs e)
        {
            Console.WriteLine(e.Point.ToString());
        }

        public void Controller()
        {
            Point p = player.Point;

            Motion m = new Motion();
            switch (m)
            {
                case (Motion.Up):
                    p.X++;
                    break;
                case (Motion.Down):
                    p.Y--;
                    break;
                case (Motion.Left):
                    p.X--;
                    break;
                case (Motion.Right):
                    p.X++;
                    break;
                default:
                    break;
            }

            player.Move(p, gamefield.Field[p.X, p.Y]);
        }

        private void PlayerCollisions(MoveEventArgs e)
        {
            foreach (Enemy s in enemies)
            {
                if (e.Point == s.Point)
                {
                    EnemyCollision(s);
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

        /// <summary>
        /// Метод выполняющийся при движении врага
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Enemy_Moving(object sender, MoveEventArgs e)
        {
            var enemy = (Enemy)sender;

            if (enemy.Point == player.Point)
            {
                enemy.SetDamage(player);
            }

            CheckGameStatus();
        }

        /// <summary>
        /// Метод,если произошло столкновение игрока с противником
        /// </summary>
        /// <param name="sender"></param>
        private void EnemyCollision(Enemy sender)
        {
            sender.SetDamage(player);
            Console.WriteLine($"Нанесен урон {sender.DamageValue}");
        }
    }
}
