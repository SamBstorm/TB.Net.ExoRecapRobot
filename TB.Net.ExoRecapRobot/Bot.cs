using System;
using System.Collections.Generic;
using System.Text;

namespace TB.Net.ExoRecapRobot
{
    public class Bot : IMovable
    {
        public ushort Position_X { get; private set; }

        public ushort Position_Y { get; private set; }

        public Orientation Direction { get; private set; }

        protected Grid Area { get; set; }

        public ListAction ListAction { get; set; }
        public event ChangePositionEventHandler ChangePosition = null;

        public Bot(ushort x, ushort y, Orientation direction, Grid area)
        {
            this.Position_X = x;
            this.Position_Y = y;
            this.Direction = direction;
            this.Area = area;
            this.ListAction = null;
        }

        public void Forward()
        {
            switch (this.Direction)
            {
                case Orientation.Up:
                    if (this.Position_Y == this.Area.Y_MaxValue) throw new OutOfGridException(this);
                    this.Position_Y++;
                    break;
                case Orientation.Right:
                    if (this.Position_X == this.Area.X_MaxValue) throw new OutOfGridException(this);
                    this.Position_X++;
                    break;
                case Orientation.Down:
                    if (this.Position_Y == 0) throw new OutOfGridException(this);
                    this.Position_Y--;
                    break;
                case Orientation.Left:
                    if (this.Position_X == 0) throw new OutOfGridException(this);
                    this.Position_X--;
                    break;
            }
            ChangePosition(this);
        }

        public void TurnLeft()
        {
            switch (this.Direction)
            {
                case Orientation.Up:
                    this.Direction = Orientation.Left;
                    break;
                case Orientation.Right:
                    this.Direction = Orientation.Up;
                    break;
                case Orientation.Down:
                    this.Direction = Orientation.Right;
                    break;
                case Orientation.Left:
                    this.Direction = Orientation.Down;
                    break;
            }
            ChangePosition(this);
        }

        public void TurnRight()
        {
            this.Direction = (Orientation)((((int)this.Direction) + 1)%4);
            ChangePosition(this);
        }
    }
}
