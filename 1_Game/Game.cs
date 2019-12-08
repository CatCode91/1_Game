using _1_Game.Bonuses;
using _1_Game.Enemies;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game
{
    public class Game
    {
        Player player = new Player();
        Enemy[] enemies = new Enemy[5];

        List<Bonus> bonuses = new List<Bonus>(5);

        Enemy[] enemiesType = new Enemy[] { new Dragon(), new Wolf() };
        Bonus[] bonusesType = new Bonus[] { new Apple(), new Cherry() };

        GameField field;

        public Game()
        {
            field = new GameField(1000,600);
            player.Moving += Player_Moving;
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

        public void CheckEnemyCollision(Enemy sender, Point p)
        {
            if (sender.Point == player.Point)
            {
                sender.SetDamage(player);
                Console.WriteLine($"Нанесен урон {sender.DamageValue}");

                CheckGameStatus();
            }
        }

        private void Player_Moving(object sender, MoveEventArgs e)
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
                    BonusCollision(s);
                }
            }

        }

        private void BonusCollision(Bonus s)
        {
            s.ApplyBonus(player);
            Console.WriteLine($"Здоровье увеличилось {s.HelpValue}");
            bonuses.Remove(s);
        }

        private void Enemy_Moving(object sender, MoveEventArgs e)
        {
            if (e.Point == player.Point)
            { 
                EnemyCollision((Enemy)sender);
            }

            CheckGameStatus();
        }

        private void EnemyCollision(Enemy sender)
        {
            sender.SetDamage(player);
            Console.WriteLine($"Нанесен урон {sender.DamageValue}");
        }
    }
}
