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

        public Material[] materials = new Material[] { new Fire(),new Water(),new Wall(),new Grass(),new Road() };

        public GameField(int width, int height)
        {
            Field = new Material[width, height];
            FieldFill(width,height);
        }

        public Material GetMaterial(Point p)
        {
            return Field[p.X, p.Y];
        }

        private void FieldFill(int width, int height)
        {
            Random random = new Random();

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Field[i, j] = materials[random.Next(0,materials.Length)];
                }
            }
        }
    }
}