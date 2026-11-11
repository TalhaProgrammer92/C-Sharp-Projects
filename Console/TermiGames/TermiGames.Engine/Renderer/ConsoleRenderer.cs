using System.Text;
using TermiGames.Engine.Extensions;
using TermiGames.Engine.Interfaces;
using TermiGames.Engine.Utilities;

namespace TermiGames.Engine.Renderer
{
    public sealed class ConsoleRenderer : IConsoleRenderer
    {
        private FrameBuffer? _previousFrame;

        public void Render(FrameBuffer frame)
        {
            ArgumentNullException.ThrowIfNull(frame);

            ConsoleColor originalForeground = Console.ForegroundColor;
            ConsoleColor originalBackground = Console.BackgroundColor;

            try
            {
                for (int y = 0; y < frame.Height; y++)
                {
                    int x = 0;

                    while (x < frame.Width)
                    {
                        Position position = new(x, y);

                        Cell current = frame.GetCell(position);

                        if (!HasChanged(frame, position, current))
                        {
                            x++;
                            continue;
                        }

                        int startX = x;

                        var output = new StringBuilder();

                        ConsoleColor foreground = current.HasColor()
                            ? current.Color!.Foreground
                            : originalForeground;
                        ConsoleColor background = current.HasColor()
                            ? current.Color!.Background ?? originalBackground
                            : originalBackground;

                        // Collect consecutive changed cells
                        // that share the same colors.
                        while (x < frame.Width)
                        {
                            Position conPosition = new(x, y);
                            current = frame.GetCell(conPosition);

                            if (!HasChanged(frame, conPosition, current))
                                break;

                            if (current.HasColor())
                            {
                                if (
                                    current.Color!.Foreground != foreground
                                    || current.Color!.Background != background
                                )
                                {
                                    break;
                                }
                            }

                            output.Append(current.Character);
                            x++;
                        }

                        Console.SetCursorPosition(startX, y);

                        Console.ForegroundColor = foreground;
                        Console.BackgroundColor = background;

                        Console.Write(output);
                    }
                }
            }
            finally
            {
                Console.ForegroundColor = originalForeground;
                Console.BackgroundColor = originalBackground;
            }

            SaveFrame(frame);
        }

        private bool HasChanged(FrameBuffer frame, Position position, Cell current)
        {
            if (_previousFrame is null)
                return true;

            if (_previousFrame.Width != frame.Width || _previousFrame.Height != frame.Height)
            {
                return true;
            }

            return current != _previousFrame.GetCell(position);
        }

        private void SaveFrame(FrameBuffer frame)
        {
            var previous = new FrameBuffer(frame.Width, frame.Height);

            for (int y = 0; y < frame.Height; y++)
            {
                for (int x = 0; x < frame.Width; x++)
                {
                    Position position = new(x, y);
                    previous.SetCell(position, frame.GetCell(position));
                }
            }

            _previousFrame = previous;
        }
    }
}
