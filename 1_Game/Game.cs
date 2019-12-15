using _1_Game.Bonuses;
using _1_Game.Enemies;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game
{
    public class Game
    {
        Player player = new Player(new Point(1,1)); //создаем объект игрока с заданными координатами
        Enemy[] enemies = new Enemy[5]; //создаем массив объектов противника

        List<Bonus> bonuses = new List<Bonus>(5); //список бонусов

        GameField field; // игровое поле

        public Game()
        {
            field = new GameField(1000, 600); //создаем игровое поле
            player.Moving += Player_Moving; //подписываем метод на событие движения игрока
            //при генерации массива врагов, подпишем каждого врага на метов Enemy_Moving
        }

        /// <summary>
        /// Метод, проверяющий завершение игры;
        /// </summary>
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

        /// <summary>
        /// Метод выполняющийся при движении игрока
        /// </summary>
        /// <param name="sender">Объект, вызвавший метод</param>
        /// <param name="e">Параметры события</param>
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
            CheckGameStatus();
        }
        /// <summary>
        /// Метод выполняющийся при движении врага
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Enemy_Moving(object sender, MoveEventArgs e)
        {
            if (e.Point == player.Point)
            {
                EnemyCollision((Enemy)sender);
            }

            CheckGameStatus();
        }

        /// <summary>
        /// Метод, если произошло "столкновение" игрока с бонусом
        /// </summary>
        /// <param name="s"></param>
        private void BonusCollision(Bonus s)
        {
            s.ApplyBonus(player);
            Console.WriteLine($"Здоровье увеличилось {s.HelpValue}");
            bonuses.Remove(s);
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
        /// <summary>
        /// Метод,если произошло столкновение с противника с игроком
        /// </summary>
        /// <param name="sender"></param>
        public void EnemyCollision(Enemy sender, Point p)
        {
            if (sender.Point == player.Point)
            {
                sender.SetDamage(player);
                Console.WriteLine($"Нанесен урон {sender.DamageValue}");
            }
        }
    }
}
