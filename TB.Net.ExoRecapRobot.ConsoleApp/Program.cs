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
                Bot Joueur = g.GeneratePlayer();
                Console.WriteLine($"Joueur position {Joueur.Position_X} - {Joueur.Position_Y} - {Joueur.Direction}");
                g.AddAction(Joueur.Forward);
                Console.WriteLine($"Joueur position {Joueur.Position_X} - {Joueur.Position_Y} - {Joueur.Direction}");
                g.AddAction(Joueur.TurnLeft);
                Console.WriteLine($"Joueur position {Joueur.Position_X} - {Joueur.Position_Y} - {Joueur.Direction}");
                g.AddAction(Joueur.Forward);
                Console.WriteLine($"Joueur position {Joueur.Position_X} - {Joueur.Position_Y} - {Joueur.Direction}");
                g.AddAction(Joueur.TurnRight);
                Console.WriteLine($"Joueur position {Joueur.Position_X} - {Joueur.Position_Y} - {Joueur.Direction}");
                g.Play();
                Console.WriteLine($"Joueur position {Joueur.Position_X} - {Joueur.Position_Y} - {Joueur.Direction}");
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }
    }
}
