using TermiArt.Models;
using TermiArt.ValueObjects;

namespace TermiArt.Art
{
    public static class House
    {
        private static Canvas Window()
        {
            Canvas canvas = new(5, 5);

            canvas.FilledBox(Position.Create(1, 1), canvas.Size, '*', new(ConsoleColor.DarkYellow));

            return canvas;
        }

        public static void Draw()
        {
            Canvas canvas = new(30, 35);

            canvas.Insert(Window(), Position.Create(15, 5));
            canvas.Insert(Window(), Position.Create(15, 15));

            canvas.Draw();
        }
    }
}
