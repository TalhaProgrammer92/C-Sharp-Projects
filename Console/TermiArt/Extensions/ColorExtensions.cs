using TermiArt.Models;

namespace TermiArt.Extensions
{
    public static class ColorExtensions
    {
        public static void Apply(this Color? color)
        {
            if (color is null)
                return;

            Console.ForegroundColor = color.Foreground;

            if (color.Background.HasValue)
                Console.BackgroundColor = color.Background.Value;
        }
    }
}
