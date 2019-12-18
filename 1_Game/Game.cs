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
        private int height, width; //размеры окна

        Player player;
        Enemy[] enemies = new Enemy[10];
        List<Bonus> bonuses = new List<Bonus>(10);
        GameField gamefield;

        public Game(int height,int width)
        {
            gamefield = new GameField(height, width);
            player = new Player();
            player.Moving += Player_Moving;
        }

        public void PlayerMoveController()
        {
            Point p = player.Point;

            ConsoleKeyInfo cki = Console.ReadKey(true);
            switch (cki.Key)
            {
                case (ConsoleKey.UpArrow):
                    p.Y++;
                    break;
                case (ConsoleKey.DownArrow):
                    p.Y--;
                    break;
                case (ConsoleKey.LeftArrow):
                    p.X--;
                    break;
                case (ConsoleKey.RightArrow):
                    p.X++;
                    break;
                default:
                    break;
            }

            //проверяем, не выходят ли координаты за пределы окна
            if ((p.X > width || p.X < 0) || (p.Y > height || p.Y < 0))
            {
                return;
            }

            player.Move(p,gamefield.Field[p.X,p.Y]);
        }

        private void Player_Moving(object sender, MoveEventArgs e)
        {
            //после передвижения игрока проверяем столкновения с другими объектами
            PlayerCollisions(e);
            //проверяем выполнение условий для завершения игры
            CheckGameStatus();
        }

        private void Enemy_Moving(object sender, MoveEventArgs e)
        {
            //при перемещении врага, проверяем столкновение с игроком
            var enemy = (Enemy)sender;

            if (enemy.Point == player.Point)
            {
                enemy.SetDamage(player);
            }

            CheckGameStatus();
        }

        private void PlayerCollisions(MoveEventArgs e)
        {
            //проверяем столкновение с врагом
            foreach (Enemy s in enemies)
            {
                if (e.Point == s.Point)
                {
                    s.SetDamage(player);
                    Console.WriteLine($"Нанесен урон {s.DamageValue}");
                }
            }

            //проверяем столкновение с бонусом
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
        /// Метод, определяющий условия для завершения игры
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
    }
}
