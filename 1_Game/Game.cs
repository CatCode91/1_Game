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
        //размеры окна статические, передаются в класс Point для валидации координат
        public static int Height { get; private set; } 
        public static int Width { get; private set; }

        GameField gamefield;
        Player player;
        List<Enemy> enemies = new List<Enemy>(10);
        List<Bonus> bonuses = new List<Bonus>(7);

        public Game(int width,int height)
        {
            Width = width;
            Height = height;

            gamefield = new GameField(width, height);
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
            player.Move(p,gamefield.Field[p.X,p.Y]);
        }

        private void Player_Moving(object sender, MoveEventArgs e)
        {
            Console.WriteLine($"Игрок находится: {player.Point}");
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
        private void CheckGameStatus()
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
