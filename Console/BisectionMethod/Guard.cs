namespace BisectionMethod
{
    public static class Guard
    {
        public static void AgainstZero(double value, string parameterName)
        {
            if (value == 0)
                throw new ArgumentException($"{parameterName} cannot be zero.", parameterName);
        }

        public static void AgainstNegative(double value, string parameterName)
        {
            if (value < 0)
                throw new ArgumentException($"{parameterName} cannot be negative.", parameterName);
        }

        public static void AgainstZeroOrLess(double value, string parameterName)
        {
            if (value <= 0)
                throw new ArgumentException($"{parameterName} cannot be zero or negative.");
        }
    }
}
