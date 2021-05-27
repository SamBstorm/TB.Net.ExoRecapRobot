using System;

namespace TB.Net.ExoRecapRobot.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Grid g = new Grid(2, 2);
                g.GeneratePlayer();
                Console.WriteLine(g.Player.Position_X);
                Console.WriteLine(g.Player.Position_Y);
                Console.WriteLine(g.Player.Direction);
                g.Player.Forward();
                Console.WriteLine(g.Player.Position_X);
                Console.WriteLine(g.Player.Position_Y);
                Console.WriteLine(g.Player.Direction);
                g.Player.Forward();
                Console.WriteLine(g.Player.Position_X);
                Console.WriteLine(g.Player.Position_Y);
                Console.WriteLine(g.Player.Direction);

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }
    }
}
