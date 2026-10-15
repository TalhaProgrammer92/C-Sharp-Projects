namespace TermiArt.Models
{
    public sealed class Color
    {
        public readonly ConsoleColor Foreground;
        public readonly ConsoleColor? Background;

        public Color(ConsoleColor fg, ConsoleColor? bg = null)
        {
            Foreground = fg;
            Background = bg;
        }
    }
}
