using _1_Game.Materials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
            Field = new Material[width, height];
            FieldFill(width,height);
        }

        //возвращает материал по координатам
        public Material GetMaterial(Point p)
        {
            return Field[p.X, p.Y];
        }

        //возращает рандомный материал
        private Material RandomMaterial()
        {
            Random r = new Random();
            Type baseType = typeof(Material);
            var allDerivedTypes = baseType.Assembly.ExportedTypes.Where(t => baseType.IsAssignableFrom(t)).Where(t => t.IsAbstract ==false).ToArray();

            Material mat = Activator.CreateInstance(Type.GetType(allDerivedTypes[r.Next(0,allDerivedTypes.Length)].FullName)) as Material;
            return mat;

        }

        //заполнение игрового поля материалами
        private void FieldFill(int width, int height)
        {
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Field[i, j] = RandomMaterial();
                }
            }
        }
    }
}