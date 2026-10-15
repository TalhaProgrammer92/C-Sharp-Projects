namespace TermiArt.ValueObjects
{
    public sealed class Position
    {
        public int X { get; }
        public int Y { get; }

        private Position(int x, int y)
        {
            X = x;
            Y = y;
        }

        public static Position Create(int x, int y) => new(x, y);

        public static Position Reduce(Position position, int offset = 1) =>
            new(position.X - 1, position.Y - 1);

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }
}
