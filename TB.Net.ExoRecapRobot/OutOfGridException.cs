using System;
using System.Collections.Generic;
using System.Text;

namespace TB.Net.ExoRecapRobot
{
    public class OutOfGridException : Exception
    {
        public ushort Position_X { get; }
        public ushort Position_Y { get; }
        public Orientation Direction { get; }


        public OutOfGridException(IMovable player) : this(player.Position_X, player.Position_Y, player.Direction)
        {

        }
        public OutOfGridException(ushort x, ushort y, Orientation direction) : base("Player get out of the Grid.")
        {
            this.Position_X = x;
            this.Position_Y = y;
            this.Direction = direction;
        }
    }
}
