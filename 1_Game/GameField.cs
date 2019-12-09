using _1_Game.Materials;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game
{
    public class GameField
    {
        private static Material[,] cells;
        private Material[] materials = new Material[] { new Water(), new Grass(), new Road() };

        public static int FieldHeight { get; private set; } //поле, содержащее значение высоты окна
        public static int FieldWidth { get; private set; } //поле, содержащее ширины окна

        /// <summary>
        /// Конструктор класса, принимающий высоту и ширину поля
        /// </summary>
        public GameField(int h, int w)
        {
            CreateGameField(h, w);
            FieldHeight = h;
            FieldWidth = w;
        }


        /// <summary>
        /// Создает массив клеток игрового поля, из доступных материалов
        /// </summary>
        private static Material[,] CreateGameField(int h, int w)
        {
            cells = new Material[h,w];
            return cells;
        }


        /// <summary>
        /// Возвращает материал по индексу ячейки
        /// </summary>
        public static Material CheckMaterial (Point p)
        {
          return cells?[p.X, p.Y];
        }
    }
}
