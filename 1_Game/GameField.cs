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

        /// <summary>
        /// Конструктор класса, принимающий высоту и ширину поля
        /// </summary>
        public GameField(int h, int w)
        {
            CreateGameField(h, w);
        }


        /// <summary>
        /// Создает массив клеток игрового поля, и каждой клетке соответствует свой материал
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
            try
            {
                return cells[p.X, p.Y];
            }

            catch
            {
                return null;
            }

           
        }
    }
}
