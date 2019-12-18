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
        //двумерный массив, представляющий собой координатную плоскость игрового поля
        public Material[,] Field { get; private set; }

        public GameField(int width, int height)
        {
            Field = new Material[width,height];
        }
    }
}