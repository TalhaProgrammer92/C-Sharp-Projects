namespace TermiGames.Engine.Utilities
{
    public sealed class Color
    {
        public readonly ConsoleColor Foreground;
        public readonly ConsoleColor? Background;

        public Color(ConsoleColor foreground, ConsoleColor? background = null)
        {
            Foreground = foreground;
            Background = background;
        }

        public void Apply()
        {
            Console.ForegroundColor = Foreground;

            if (Background.HasValue)
                Console.BackgroundColor = Background.Value;
        }
    }
}
