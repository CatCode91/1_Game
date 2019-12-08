using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game
{
    interface IMovable
    {
        Point Point { get; set; }

        void Move();
    }
}
