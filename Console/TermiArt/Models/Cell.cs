using TermiArt.Extensions;

namespace TermiArt.Models
{
    public sealed class Cell
    {
        public char Value;
        public readonly Color? color;
        public bool IsEmpty => Value == ' ';

        public Cell(char value, Color? color = null)
        {
            Value = value;
            this.color = color;
        }

        public void Display()
        {
            color.Apply();

            Console.Write(Value);

            Console.ResetColor();
        }
    }
}
