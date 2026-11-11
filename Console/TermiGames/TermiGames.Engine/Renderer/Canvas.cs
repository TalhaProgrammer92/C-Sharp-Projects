using TermiGames.Engine.Enums;
using TermiGames.Engine.Extensions;
using TermiGames.Engine.Utilities;

namespace TermiGames.Engine.Renderer
{
    public sealed class Canvas
    {
        public readonly Size Size;
        private Cell[,] _cells;

        public Canvas(int width, int height)
        {
            Size = new(width, height);
            _cells = new Cell[Size.Width, Size.Height];

            // Initialize
            DrawRectangle(new(0, 0), Size, new(' '));
        }

        public void SetCell(Position position, Cell cell)
        {
            if (!Size.InBounds(position))
                throw new ArgumentOutOfRangeException(
                    nameof(position),
                    "Position is out of bounds."
                );

            _cells[position.X, position.Y] = cell;
        }

        public Cell GetCell(Position position)
        {
            if (!Size.InBounds(position))
                throw new ArgumentOutOfRangeException(
                    nameof(position),
                    "Position is out of bounds."
                );

            return _cells[position.X, position.Y];
        }

        public void Clear()
        {
            _cells = new Cell[Size.Width, Size.Height];
        }

        /* <----- Shapes Builder -----> */

        public void DrawRectangle(Position position, Size size, Cell cell, bool isFilled = true)
        {
            for (int y = 0; y < size.Height; y++)
            {
                for (int x = 0; x < size.Width; x++)
                {
                    Position currentPosition = new(position.X + x, position.Y + y);

                    if (isFilled)
                    {
                        if (!Size.InBounds(currentPosition))
                            continue;

                        SetCell(currentPosition, cell);
                    }
                    else
                    {
                        // Draw only the border of the rectangle
                        if (y == 0 || y == size.Height - 1 || x == 0 || x == size.Width - 1)
                        {
                            if (!Size.InBounds(currentPosition))
                                continue;

                            SetCell(currentPosition, cell);
                        }
                    }
                }
            }
        }

        public void DrawLine(Position start, Position end, Cell cell)
        {
            int dx = Math.Abs(end.X - start.X);
            int dy = Math.Abs(end.Y - start.Y);
            int sx = start.X < end.X ? 1 : -1;
            int sy = start.Y < end.Y ? 1 : -1;
            int err = dx - dy;

            while (true)
            {
                if (Size.InBounds(start))
                    SetCell(start, cell);

                if (start.X == end.X && start.Y == end.Y)
                    break;

                int e2 = err * 2;
                if (e2 > -dy)
                {
                    err -= dy;
                    start = new Position(start.X + sx, start.Y);
                }
                if (e2 < dx)
                {
                    err += dx;
                    start = new Position(start.X, start.Y + sy);
                }
            }
        }

        public void DrawDiagonolLine(
            Position start,
            int size,
            Cell cell,
            DiagonalLineDirection direction
        )
        {
            int x = start.X,
                y = start.Y;

            for (int i = 0; i < size; i++)
            {
                Position position = direction switch
                {
                    DiagonalLineDirection.TopRight => new(x - i, y + i),
                    DiagonalLineDirection.TopLeft => new(x - i, y - i),
                    DiagonalLineDirection.BottomLeft => new(x + i, y - i),
                    DiagonalLineDirection.BottomRight => new(x + i, y + i),
                    _ => throw new NotImplementedException(),
                };

                SetCell(position, cell);
            }
        }

        public void DrawText(Position position, string text, Cell cell)
        {
            for (int i = 0; i < text.Length; i++)
            {
                Position currentPosition = new(position.X + i, position.Y);

                if (!Size.InBounds(currentPosition))
                    continue;

                SetCell(currentPosition, cell with { Character = text[i] });
            }
        }

        public void DrawCircle(Position center, int radius, Cell cell, bool isFilled = true)
        {
            int x = radius;
            int y = 0;
            int err = 0;

            while (x >= y)
            {
                DrawCirclePoints(center, x, y, cell, isFilled);
                y++;
                err += 1 + 2 * y;
                if (2 * (err - x) + 1 > 0)
                {
                    x--;
                    err += 1 - 2 * x;
                }
            }
        }

        private void DrawCirclePoints(Position center, int x, int y, Cell cell, bool isFilled)
        {
            Position[] points =
            [
                new(center.X + x, center.Y + y),
                new(center.X - x, center.Y + y),
                new(center.X + x, center.Y - y),
                new(center.X - x, center.Y - y),
                new(center.X + y, center.Y + x),
                new(center.X - y, center.Y + x),
                new(center.X + y, center.Y - x),
                new(center.X - y, center.Y - x),
            ];

            foreach (var point in points)
            {
                if (Size.InBounds(point))
                    SetCell(point, cell);
            }

            if (isFilled)
            {
                for (int i = center.X - x; i <= center.X + x; i++)
                {
                    for (int j = center.Y - y; j <= center.Y + y; j++)
                    {
                        Position fillPoint = new(i, j);

                        if (Size.InBounds(fillPoint))
                            SetCell(fillPoint, cell);
                    }
                }
            }
        }

        public void DrawCanvas(Position position, Canvas canvas, bool ignoringVoids = false)
        {
            int x = 0,
                endX = position.X + canvas.Size.Width,
                endY = position.Y + canvas.Size.Height;

            //Message.Info($"End: ({endX}, {endY})");

            for (int i = position.X; i < endX; i++)
            {
                int y = 0;

                for (int j = position.Y; j < endY; j++)
                {
                    //Message.Info($"Current (In): ({i}, {j})");
                    //Message.Info($"Current (Out): ({x}, {y})");

                    var cell = canvas.GetCell(new(x, y++));

                    if (ignoringVoids && cell.IsEmpty())
                        continue;

                    SetCell(new(i, j), cell);
                }

                x++;
            }
        }

        // For Testing
        public void Display()
        {
            for (int i = 0; i < Size.Width; i++)
            {
                for (int j = 0; j < Size.Height; j++)
                {
                    var cell = GetCell(new(i, j));

                    // DIsplay cell
                    cell.Print();
                }

                Console.WriteLine();
            }
        }
    }
}
