using TermiGames.Engine.Utilities;

namespace TermiGames.Engine.Extensions
{
    public static class SizeExtension
    {
        public static bool InBounds(this Size size, Position position)
        {
            return position.X >= 0
                && position.X < size.Width
                && position.Y >= 0
                && position.Y < size.Height;
        }
    }
}
