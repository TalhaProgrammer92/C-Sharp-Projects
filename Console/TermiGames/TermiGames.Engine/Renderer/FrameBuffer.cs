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
            if (position.X < 0 || position.X >= Width || position.Y < 0 || position.Y >= Height)
            {
                return;
            }

            _cells[position.Y, position.X] = cell;
        }

        public Cell GetCell(Position position)
        {
            return _cells[position.Y, position.X];
        }
    }
}
