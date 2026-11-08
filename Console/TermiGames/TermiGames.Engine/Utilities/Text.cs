namespace TermiGames.Engine.Utilities
{
    public static class Text
    {
        public static void Write(string text, Color color)
        {
            color.Apply();
            Console.Write(text);
            Console.ResetColor();
        }

        public static void WriteLine(string text, Color color)
        {
            color.Apply();
            Console.Write(text);
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}
