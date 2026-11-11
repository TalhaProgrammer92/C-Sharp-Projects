namespace BisectionMethod
{
    public static class Extensions
    {
        public static string StrValue(this Interval interval) =>
            $"[{interval.Start}, {interval.End}]";
    }
}
