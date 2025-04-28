namespace Chess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Player player = new Player("Talha Ahmad");

            player.score.updateScore(55);
            player.won_match = 0;
            player.lose_match = 1;

            player.displayStats();
        }
    }
}
