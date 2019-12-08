using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Game
{
    public delegate void MoveStateHandler(object sender,MoveEventArgs e);

    public class MoveEventArgs
    {
        public string Message { get; private set; }
        public Point p { get; private set; }

        /// <summary>
        /// Используйте для прикрепления текстового сообщения
        /// </summary>
        /// <param name="_mes">Сообщение</param>
        public MoveEventArgs(string _mes)
        {
            Message = _mes;
        }

        /// <summary>
        /// Используйте для прикрепления текстового сообщения и координат
        /// </summary>
        /// <param name="_mes">Сообщение</param>
        /// <param name="_p">Координаты</param>
        public MoveEventArgs(string _mes, Point _p)
        {
            Message = _mes;
            p = _p;
        }
    }
}
