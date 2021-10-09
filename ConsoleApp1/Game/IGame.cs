namespace ConsoleApp1
{
    public interface IGame
    {
        string Category { get; set; }
        string GameName { get; set; }

        void GameEnd();
        void GameStart();
    }
}