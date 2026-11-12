namespace BisectionMethod
{
    public static class Examples
    {
        public static void WithoutTolerance()
        {
            Console.WriteLine("\n<=========== Without Tolerance ===========>\n");

            Function func = new();

            func.AddVariable(1, 2);
            func.AddConstant(3, Sign.MINUS);

            Interval interval = new(1, 2);

            // Precision is approx. 1.7321
            Console.WriteLine($"{func}, {interval.StrValue()}\n");
            Console.WriteLine(
                $"Root Precision: {Bisection.EvaluateRootPrecision(func, interval, true):0.#####}"
            );
        }

        public static void WithTolerance()
        {
            Console.WriteLine("\n<=========== With Tolerance ===========>\n");

            Function func = new();

            func.AddVariable(1, 3);
            func.AddVariable(1, 1, Sign.MINUS);
            func.AddConstant(2, Sign.MINUS);

            Interval interval = new(1, 2);
            double tolerance = 0.05;

            // Precision is approx. 1.5214
            Console.WriteLine($"{func}, {interval.StrValue()} | {tolerance}\n");
            Console.WriteLine(
                $"Root Precision: {Bisection.EvaluateRootPrecision(func, interval, tolerance, true):0.#####}"
            );
        }
    }
}
