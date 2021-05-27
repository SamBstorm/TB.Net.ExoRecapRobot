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
                Joueur.ChangePosition += delegate (IMovable j) { 
                    Console.WriteLine($"Joueur position {j.Position_X} - {j.Position_Y} - {j.Direction}"); 
                };
                Joueur.ChangePosition += Beep;
                g.AddAction(Joueur.Forward);
                g.AddAction(Joueur.TurnLeft);
                g.AddAction(Joueur.Forward);
                g.AddAction(Joueur.TurnRight);
                g.Play();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }
        static void Beep(IMovable j)
        {
            Console.Beep(50, 500);
        }
    }
}
