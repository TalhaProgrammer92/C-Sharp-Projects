using TermiGames.Engine.Renderer;

namespace TermiGames.Engine.Extensions
{
    public static class CellExtension
    {
        public static void Print(this Cell cell)
        {
            cell.Color?.Apply();
            Console.Write(cell.Character);
            Console.ResetColor();
        }

        public static bool HasColor(this Cell cell) => cell.Color is not null;

        public static bool HasChanged(this Cell cell, Cell previousCell)
        {
            // Check color
            if (cell.HasColor() || previousCell.HasColor())
            {
                return !cell.Color!.Equals(previousCell.Color);
            }

            // Check character
            return cell.Character != previousCell.Character;
        }

        public static bool IsEmpty(this Cell cell)
        {
            return !cell.HasColor() && cell.Character == ' ';
        }
    }
}
