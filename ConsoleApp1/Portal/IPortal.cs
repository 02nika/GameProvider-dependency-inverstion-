namespace ConsoleApp1
{
    public interface IPortal
    {
        string Name { get; set; }
        string URL { get; set; }

        void AddGame(IGame game);
        void DeleteGame(IGame game);
        void GetGames();
    }
}