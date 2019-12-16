using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game
{
    public delegate void MoveStateHandler(object sender,MoveEventArgs e);

    public class MoveEventArgs
    {
        public Point Point { get; private set; }

        public MoveEventArgs(Point _p)
        {
            Point = _p;
        }
    }
}
