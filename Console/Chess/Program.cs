namespace Chess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Set console encoding to UTF-8
            Symbol.setUtf8();

            // Player - Test
            Player player = new Player("Talha Ahmad");

            player.score.updateScore(55);
            player.won_match = 0;
            player.lose_match = 1;

            player.displayStats();

            // Symbol - Test
            Console.WriteLine(Symbol.BLACK_KNIGHT);

            // Board - Test
            Board board = new Board();
            board.placePiecesAtDefaultPoistions();
            board.displayBoard();
        }
    }
}
