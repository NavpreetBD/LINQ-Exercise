namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> videoGames = new List<string>()
            {
                "Fortnite",
                "ROBLOX",
                "Minecraft",
                "League of Legends",
                "Valorant",
                "Rocket League"
            };

            var sortedGames = videoGames.OrderBy(name => name.Length);
            foreach (var game in sortedGames)
            {
                Console.WriteLine(game);
            }
        }
    }
}
