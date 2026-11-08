namespace TermiGames.Engine.Utilities
{
    public static class Message
    {
        public static void Info(string message)
        {
            Text.WriteLine($"[INFO] {message}", new(ConsoleColor.White, ConsoleColor.DarkCyan));
        }

        public static void Warning(string message)
        {
            Text.WriteLine(
                $"[WARNING] {message}",
                new(ConsoleColor.White, ConsoleColor.DarkYellow)
            );
        }

        public static void Error(string message)
        {
            Text.WriteLine($"[ERROR] {message}", new(ConsoleColor.White, ConsoleColor.DarkRed));
        }

        public static void Success(string message)
        {
            Text.WriteLine($"[SUCCESS] {message}", new(ConsoleColor.White, ConsoleColor.DarkGreen));
        }
    }
}
