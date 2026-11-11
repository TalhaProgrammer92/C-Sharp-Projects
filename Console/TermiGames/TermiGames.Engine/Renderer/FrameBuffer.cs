using TermiGames.Engine.Utilities;

namespace TermiGames.Engine.Renderer
{
    public sealed class FrameBuffer
    {
        private readonly Cell[,] _cells;

        public int Width { get; }
        public int Height { get; }

        public FrameBuffer(int width, int height)
        {
            Width = width;
            Height = height;

            _cells = new Cell[height, width];
        }

        public void SetCell(Position position, Cell cell)
        {
            // Check if the position is within the bounds of the framebuffer
            if (position.X < 0 || position.X >= Width)
                throw new ArgumentOutOfRangeException(nameof(position.X));

            if (position.Y < 0 || position.Y >= Height)
                throw new ArgumentOutOfRangeException(nameof(position.Y));

            // Setting the cell at the specified position and setting it to the new cell
            _cells[position.Y, position.X] = cell;
        }

        public Cell GetCell(Position position)
        {
            if (position.X < 0 || position.X >= Width)
                throw new ArgumentOutOfRangeException(nameof(position.X));

            if (position.Y < 0 || position.Y >= Height)
                throw new ArgumentOutOfRangeException(nameof(position.Y));

            return _cells[position.Y, position.X];
        }

        public void Clear(Cell cell)
        {
            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    _cells[y, x] = cell;
                }
            }
        }
    }
}
