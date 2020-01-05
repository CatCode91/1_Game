using _1_Game.Bonuses;
using _1_Game.Enemies;
using _1_Game.Enemies.Animals;
using _1_Game.Field;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game
{
    public class Game
    {
        private GameField gameField;
        private Player player;
        private List<Enemy> enemies = new List<Enemy>(10);
        private List<Bonus> bonuses = new List<Bonus>(7);
        private GameController gameController = new GameController();

        public Game(int width,int height)
        {
            Width = width;
            Height = height;

            gameField = new GameField(width, height);
            player = new Player();
            player.Moving += Player_Moving;
        }

        //размеры окна статические, передаются в класс Point для валидации координат
        public static int Height { get; private set; }
        public static int Width { get; private set; }

        public void MoveController(ConsoleKey cli)
        {
            Vector vector = gameController.DoStep(cli);

            if (vector != null)
            {
                //передает желаемое направление и материал в клетке по направлению
                player.Move(vector,gameField.GetMaterial(player.Point+vector));
            }
        }

        //метод события Move в Player
        private void Player_Moving(IMovable sender, MoveEventArgs e)
        {
            Console.WriteLine($"Игрок находится: {player.Point}");
            Console.WriteLine($"Здоровье игрока: {player.Health}");
            Console.WriteLine($"Нахожусь на: {e.Text}");
            //после передвижения игрока проверяем столкновения с другими объектами
            PlayerCollisions(e);
            //проверяем выполнение условий для завершения игры
            CheckGameStatus();
        }
  
        //метод, события Move в Enemy
        private void Enemy_Moving(IMovable sender, MoveEventArgs e)
        {
            if (sender.Point == player.Point)
            {
                if (sender is Enemy)
                {
                    Enemy enemy = (Enemy)sender;
                    enemy.SetDamage(player);
                }

                CheckGameStatus();
            }           
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
            for (int i =0; i<bonuses.Count;i++)
            {
                if (e.Point == bonuses[i].Point)
                {
                    bonuses[i].ApplyBonus(player);
                    Console.WriteLine($"Здоровье увеличилось {bonuses[i].HelpValue}");
                    bonuses.Remove(bonuses[i]);
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
