using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game.Field
{
    public class GameField
    {
        private Material[,] cells;

        /// <summary>
        /// Конструктор класса, принимающий высоту и ширину поля
        /// </summary>
        public GameField(int h, int w)
        {
            CreateGameField(h, w);
        }

        /// <summary>
        /// Создает массив клеток игрового поля, из доступных материалов
        /// </summary>
        private Material[,] CreateGameField(int h, int w)
        {
            cells = new Material[h,w];
            return cells;
        }

        /// <summary>
        /// Возвращает материал по индексу ячейки
        /// </summary>
        public Material CheckMaterial (Point p)
        {
          return cells?[p.X, p.Y];
        }
    }
}