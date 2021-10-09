using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class Factory
    {
        public static IPlayer CreatePlayer()
        {
            return new Player();
        }

        public static IGame CreateGame()
        {
            return new Game();
        }

        public static IPortal CreatePortal()
        {
            return new Portal(CreateIlistIGame());
        }

        public static IList<IGame> CreateIlistIGame()
        {
            return new List<IGame>();
        }

    }
}
