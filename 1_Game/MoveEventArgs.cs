using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game
{
    public delegate void MoveStateHandler(IMovable sender, MoveEventArgs e);

    public class MoveEventArgs : EventArgs
    {
        public Point Point { get; private set; }
        public string Text { get; private set; }

        public MoveEventArgs(Point _p, string text)
        {
            Point = _p;
            Text = text;
        }
    }
}
