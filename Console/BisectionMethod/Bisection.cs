namespace BisectionMethod
{
    public static class Bisection
    {
        public static bool ContainsRoot(Function function, Interval interval)
        {
            return function.GetSignOfTwoFunctionInputs(interval.Start, interval.End) == Sign.MINUS
                ? true
                : false;
        }

        public static double? EvaluateRootPrecision(
            Function function,
            Interval interval,
            bool showSteps = false
        )
        {
            if (!ContainsRoot(function, interval))
            {
                Console.WriteLine("The function provided doesn't contain any roots.");
                return null;
            }

            double midPoint = (interval.Start + interval.End) / 2.0;

            // Show steps if user wants to see them.
            if (showSteps)
            {
                Console.WriteLine($"Interval: {interval.StrValue()}");
                Console.WriteLine($"Midpoint: {midPoint:0.#####}");
                Console.WriteLine($"f({midPoint:0.#####}) = {function.Evaluate(midPoint):0.#####}");
                Console.WriteLine();
            }

            // Prevent infinite steps in case of a root that is not exactly zero.
            if (Math.Abs(function.Evaluate(midPoint)) <= 0.0001)
                return midPoint;

            // Check where the root lies in given interval.
            var sign = function.GetSignOfTwoFunctionInputs(interval.Start, midPoint);

            if (sign == Sign.MINUS) // Root lies somewhere between interval start and the midpoint.
            {
                return EvaluateRootPrecision(function, new(interval.Start, midPoint), showSteps);
            }
            else // Root lies somewhere between the midpoint and interval end.
            {
                return EvaluateRootPrecision(function, new(midPoint, interval.End), showSteps);
            }
        }

        public static double? EvaluateRootPrecision(
            Function function,
            Interval interval,
            double tolerance,
            bool showSteps = false
        )
        {
            if (!ContainsRoot(function, interval))
            {
                Console.WriteLine("The function provided doesn't contain any roots.");
                return null;
            }

            double midPoint = (interval.Start + interval.End) / 2.0;
            double width = (interval.End - interval.Start) / 2.0;

            // Show steps if user wants to see them.
            if (showSteps)
            {
                Console.WriteLine($"Interval: {interval.StrValue()}");
                Console.WriteLine($"Midpoint: {midPoint:0.#####}");
                Console.WriteLine($"f({midPoint:0.#####}) = {function.Evaluate(midPoint):0.#####}");
                Console.WriteLine($"Width: {width:0.#####}");
                Console.WriteLine();
            }

            if (width < tolerance)
                return midPoint;

            // Check where the root lies in given interval.
            var sign = function.GetSignOfTwoFunctionInputs(interval.Start, midPoint);

            if (sign == Sign.MINUS) // Root lies somewhere between interval start and the midpoint.
            {
                return EvaluateRootPrecision(
                    function,
                    new(interval.Start, midPoint),
                    tolerance,
                    showSteps
                );
            }
            else // Root lies somewhere between the midpoint and interval end.
            {
                return EvaluateRootPrecision(
                    function,
                    new(midPoint, interval.End),
                    tolerance,
                    showSteps
                );
            }
        }
    }
}
