namespace TermiArt.ValueObjects
{
    public sealed class Size
    {
        public int Rows { get; }
        public int Columns { get; }
        public int Area => Rows * Columns;

        private Size(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
        }

        public static Size Create(int rows, int columns) => new(rows, columns);

        public override string ToString()
        {
            return $"({Rows}, {Columns})";
        }
    }
}
