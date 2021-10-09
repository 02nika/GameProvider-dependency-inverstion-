using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Game : IGame
    {
        public string GameName { get; set; }
        public string Category { get; set; }
        private bool _status = false;

        public void GameStart()
        {
            Console.WriteLine($"Game: {GameName} started.");
            _status = true;
        }

        public void GameEnd()
        {
            Console.WriteLine($"Game: {GameName} ended.");
            _status = false;
        }
    }
}
