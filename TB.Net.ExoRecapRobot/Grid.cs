using System;

namespace TB.Net.ExoRecapRobot
{
    public class Grid
    {
        public ushort X_MaxValue { get; private set; }
        public ushort Y_MaxValue { get; private set; }
        private IMovable Player { get; set; }

        public Grid(ushort Limit_X, ushort Limit_Y)
        {
            X_MaxValue = Limit_X;
            Y_MaxValue = Limit_Y;
        }

        public Bot GeneratePlayer()
        {
            if (!(this.Player is null)) throw new Exception("Already a Player on the Grid");
            this.Player = new Bot(
                (ushort)(X_MaxValue / 2),
                (ushort)(Y_MaxValue / 2),
                Orientation.Up,
                this
                );
            return (Bot)this.Player;
        }

        public void AddAction(ListAction action)
        {
            this.Player.ListAction += action;
        }

        public void Play()
        {
            if (this.Player.ListAction is null) throw new Exception("No action listed");
            this.Player.ListAction();
        }
    }
}