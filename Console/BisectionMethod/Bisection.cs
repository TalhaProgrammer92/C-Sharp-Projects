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
            double? tolerance = null
        )
        {
            Console.Write("Press any key to continue...");
            Console.ReadKey();
            Console.WriteLine();

            if (!ContainsRoot(function, interval))
            {
                Console.WriteLine("The function provided doesn't contain any roots.");
                return null;
            }

            double midPoint = (interval.Start + interval.End) / 2.0;

            // If user provides tolerance
            if (tolerance.HasValue)
            {
                double width = (interval.End - interval.Start) / 2.0;

                if (width < tolerance)
                    return midPoint;
            }
            // Otherwise...
            else
            {
                if (function.Evaluate(midPoint) == 0)
                    return midPoint;
            }

            // Check where the root lies in given interval.
            var sign = function.GetSignOfTwoFunctionInputs(interval.Start, midPoint);

            if (sign == Sign.MINUS) // Root lies somewhere between interval start and the midpoint.
            {
                Console.WriteLine(
                    $"[INFO] a = {interval.Start}, b = {interval.End}, c = {midPoint}, f(c) = {function.Evaluate(midPoint)}, Sign of f(c) = {sign}, new interval = [{interval.Start}, {midPoint}]"
                );

                return EvaluateRootPrecision(function, new(interval.Start, midPoint), tolerance);
            }
            else // Root lies somewhere between the midpoint and interval end.
            {
                Console.WriteLine(
                    $"[INFO] a = {interval.Start}, b = {interval.End}, c = {midPoint}, f(c) = {function.Evaluate(midPoint)}, Sign of f(c) = {sign}, new interval = [{midPoint}, {interval.End}]"
                );

                return EvaluateRootPrecision(function, new(midPoint, interval.End), tolerance);
            }
        }
    }
}
