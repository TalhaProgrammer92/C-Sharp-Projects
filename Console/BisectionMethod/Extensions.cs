namespace BisectionMethod
{
    public static class Extensions
    {
        public static string StrValue(this Interval interval) =>
            $"[{interval.Start:0.#####}, {interval.End:0.#####}]";
    }
}
