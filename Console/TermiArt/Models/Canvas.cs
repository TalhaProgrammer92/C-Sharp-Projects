using TermiArt.Enums;
using TermiArt.ValueObjects;

namespace TermiArt.Models
{
    public sealed class Canvas
    {
        private Cell[,] grid;
        public Size Size { get; }

        public Canvas(int rows, int columns)
        {
            Size = Size.Create(rows, columns);
            grid = new Cell[Size.Rows, Size.Columns];
            Init();
        }

        public Cell GetCell(Position position) => grid[position.X - 1, position.Y - 1];

        // Initialization
        private void Init()
        {
            for (int i = 0; i < Size.Rows; i++)
            {
                for (int j = 0; j < Size.Columns; j++)
                    grid[i, j] = new(' ');
            }
        }

        // Draw single
        public void Insert(Position position, char value, Color? color = null)
        {
            grid[position.X - 1, position.Y - 1] = color is null
                ? new(value, grid[position.X - 1, position.Y - 1].color)
                : new(value, color);
        }

        // Insert another canvas
        public void Insert(Canvas canvas, Position position, bool removeBg = false)
        {
            int ci = 1;

            for (int i = position.X; i < position.X + canvas.Size.Rows; i++)
            {
                int cj = 1;

                for (int j = position.Y; j < position.Y + canvas.Size.Columns; j++)
                {
                    var cell = canvas.GetCell(Position.Create(ci, cj++));

                    if (removeBg)
                    {
                        if (!cell.IsEmpty)
                            Insert(Position.Create(i, j), cell.Value, cell.color);
                    }
                    else
                    {
                        Insert(Position.Create(i, j), cell.Value, cell.color);
                    }
                }

                ci++;
            }
        }

        // Create a box
        public void FilledBox(Position position, Size size, char value, Color? color = null)
        {
            var pos = Position.Reduce(position);

            for (int i = pos.X; i < pos.X + size.Rows; i++)
            {
                for (int j = pos.Y; j < pos.Y + size.Columns; j++)
                {
                    Insert(Position.Create(i + 1, j + 1), value, color);
                }
            }
        }

        public void HollowBox(Position position, Size size, char value, Color? color = null)
        {
            var initialRow = position.X - 1;
            var finalRow = position.X + size.Rows - 1;
            var initialColumn = position.Y - 1;
            var finalColumn = position.Y + size.Columns - 1;

            for (int i = initialRow; i < finalRow; i++)
            {
                for (int j = initialColumn; j < finalColumn; j++)
                {
                    var pos = Position.Create(i + 1, j + 1);

                    if (i == initialRow || i == finalRow - 1)
                    {
                        Insert(pos, value, color);
                    }
                    else if (j == initialColumn || j == finalColumn - 1)
                    {
                        Insert(pos, value, color);
                    }
                }
            }
        }

        // Draw Line
        public void HorizontalLine(
            Position position,
            int length,
            char value,
            Color? color = null,
            Direction direction = Direction.Forward
        )
        {
            if (direction == Direction.Forward)
            {
                for (int i = position.X; i < position.Y + length; i++)
                    Insert(Position.Create(position.X + 1, i + 1), value, color);
            }
            else if (direction == Direction.Backward)
            {
                for (int i = position.X; i > Math.Abs(position.Y - length); i--)
                    Insert(Position.Create(position.X + 1, i + 1), value, color);
            }
        }

        public void VerticalLine(
            Position position,
            int length,
            char value,
            Color? color = null,
            Direction direction = Direction.Forward
        )
        {
            var pos = Position.Reduce(position);

            if (direction == Direction.Forward)
            {
                for (int i = pos.Y; i < pos.X + length; i++)
                    Insert(Position.Create(i + 1, pos.Y + 1), value, color);
            }
            else if (direction == Direction.Backward)
            {
                for (int i = pos.Y; i > Math.Abs(pos.X - length); i--)
                    Insert(Position.Create(i + 1, pos.Y + 1), value, color);
            }
        }

        public void DiagonalLine(
            Position position,
            int length,
            char value,
            Color? color = null,
            DiagonalDirection direction = DiagonalDirection.TopRight
        )
        {
            for (int i = 0; i < length; i++)
            {
                Position pos = direction switch
                {
                    DiagonalDirection.TopRight => Position.Create(position.X + 1, position.Y + 1),
                    DiagonalDirection.TopLeft => Position.Create(position.X + 1, position.Y - 1),
                    DiagonalDirection.BottomRight => Position.Create(
                        position.X - 1,
                        position.Y + 1
                    ),
                    DiagonalDirection.BottomLeft => Position.Create(position.X - 1, position.Y - 1),
                    _ => position,
                };

                Insert(position, value, color);
            }
        }

        public void CircleHollow(Position position, int radius, char value, Color? color = null)
        {
            for (int i = position.X; i < 2 * radius + 1; i++)
            {
                for (int j = position.Y; j < 2 * radius + 1; j++)
                {
                    var dist = Math.Sqrt(Math.Pow(i - radius, 2) + Math.Pow(j - radius, 2));

                    if (dist > radius - 0.7 && dist < radius + 0.7)
                    {
                        Insert(Position.Create(i, j), value, color);
                    }
                }
            }

            /*
            import math
            
            def print_circle(radius):
              for i in range(2 * radius + 1):
                for j in range(2 * radius + 1):
                  dist = math.sqrt((i - radius) ** 2 + (j - radius) ** 2)
                  if (
                      radius - 0.7 < dist < radius + 0.7
                  ):  // Adjust thickness or character aspect ratio if needed
                    print("*", end=" ")
                  else:
                    print(" ", end=" ")
                print()
            
            
            print_circle(10)
            */
        }

        public void CircleFilled(Position position, int radius, char value, Color? color = null)
        {
            /*
            def print_filled_circle(r):
              for i in range(-r, r + 1):
                for j in range(-r, r + 1):
                  if i * i + j * j <= r * r:
                    print("*", end=" ")
                  else:
                    print(" ", end=" ")
                print()


            print_filled_circle(10)
            */
        }

        // Draw the canvas
        public void Draw()
        {
            for (int i = 0; i < Size.Rows; i++)
            {
                for (int j = 0; j < Size.Columns; j++)
                {
                    grid[i, j].Display();
                }

                Console.WriteLine();
            }
        }
    }
}
