using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game
{
    enum Motions
    {
        Up,
        Down,
        Left,
        Right
    }

    class MoveController
    {
        Player player;

        public MoveController(Player p)
        {
            p = player;
        }

        public void MovePlayerController()
        {
            Point p = player.Point;

            Motion m = new Motion();
            switch (m)
            {
                case (Motion.Up):
                    p.X++;
                    break;
                case (Motion.Down):
                    p.Y--;
                    break;
                case (Motion.Left):
                    p.X--;
                    break;
                case (Motion.Right):
                    p.X++;
                    break;
                default:
                    break;
            }
        }
    }
}
