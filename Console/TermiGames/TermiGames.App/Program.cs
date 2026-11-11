using TermiGames.Engine.Enums;
using TermiGames.Engine.Renderer;

Canvas canvas = new(20, 20);

canvas.DrawRectangle(new(0, 0), canvas.Size, new('*', new(ConsoleColor.Blue)), false);

canvas.DrawCircle(new(9, 9), 5, new('@', new(ConsoleColor.Yellow)), false);

Canvas window = new(6, 6);

window.DrawRectangle(new(0, 0), new(3, 3), new('#', new(ConsoleColor.Magenta)), false);
window.DrawRectangle(new(0, 2), new(3, 3), new('#', new(ConsoleColor.Magenta)), false);
window.DrawRectangle(new(2, 0), new(3, 3), new('#', new(ConsoleColor.Magenta)), false);
window.DrawRectangle(new(2, 2), new(3, 3), new('#', new(ConsoleColor.Magenta)), false);

canvas.DrawCanvas(new(7, 7), window, true);

canvas.Display();

//canvas.Display();

//using TermiGames.Engine.Renderer;

//Console.CursorVisible = false;

//var frame = new FrameBuffer(30, 10);

//var renderer = new ConsoleRenderer();

//frame.SetCell(new(5, 3), new('@', new(ConsoleColor.Green, ConsoleColor.Black)));

//renderer.Render(frame);

//Thread.Sleep(1000);

//frame.SetCell(new(6, 3), new('@', new(ConsoleColor.Green, ConsoleColor.Black)));

//renderer.Render(frame);

//Console.SetCursorPosition(0, 9);
//Console.WriteLine("Rendering test completed.");
