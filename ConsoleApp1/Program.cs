using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            IPlayer player1 = Factory.CreatePlayer();
            player1.FirstName = "nika";
            player1.LastName = "tsitsilashvili";
            player1.Gender = "Female";
            player1.Age = 18;

            IPortal portal = Factory.CreatePortal();
            portal.Name = "Y8";
            portal.URL = "https://y8.com";
            
            IGame game1 = Factory.CreateGame();
            game1.GameName = "Fire and Water";
            game1.Category = "Puzzle";

            IGame game2 = Factory.CreateGame();
            game2.GameName = "Vector Run";
            game2.Category = "Run Game";

            portal.AddGame(game1);
            portal.AddGame(game2);
            portal.GetGames();
        }
    }
}
