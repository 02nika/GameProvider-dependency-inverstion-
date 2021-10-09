using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Portal : IPortal
    {
        public string Name { get; set; }

        public string URL { get; set; }

        private IList<IGame> _GamesList;

        public Portal(IList<IGame> games)
        {
            this._GamesList = games;
        }

        public void GetGames()
        {
            foreach (var game in _GamesList)
            {
                Console.WriteLine($"game: {game.GameName}, category: {game.Category}.");
            }
        }

        public void AddGame(IGame game)
        {
            _GamesList.Add(game);
            Console.WriteLine($"Game: {game.GameName} added into {Name}.");
        }

        public void DeleteGame(IGame game)
        {
            _GamesList.Remove(game);
            Console.WriteLine($"Game: {game.GameName} deleted from {Name}.");
        }
    }
}
