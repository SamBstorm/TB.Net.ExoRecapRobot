using System;
using System.Collections.Generic;
using System.Text;

namespace TB.Net.ExoRecapRobot
{
    public interface IMovable
    {
        ushort Position_X { get; }
        ushort Position_Y { get; }
        Orientation Direction { get; }

        void Forward();
        void TurnLeft();
        void TurnRight();

    }
}
