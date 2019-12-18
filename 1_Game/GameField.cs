using _1_Game.Materials;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game.Field
{
    /// <summary>
    /// Класс игрового поля
    /// </summary>
    public class GameField
    {
        public Material[,] Field { get; private set; }

        public GameField(int height, int width)
        {
            Field = new Material[height, width];
        }
    }
}