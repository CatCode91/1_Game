using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game.Materials
{
    //Шагая по клеткам из этого материала игрок устает, если мало здоровья 
    public class Road : Material
    {
        public override string Name => "Дорога";
        public virtual string Color { get; } = "Черный";
        public virtual int SurfaceCoef { get; } = 13;

        public override bool IsMovable(IBody obj)
        {
            if (obj is Player && obj.Health > 10)
            {
                obj.SetStrench(-1);

                if (SurfaceCoef > 40 & obj.Strench < 50)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
