using TermiArt.ValueObjects;

namespace TermiArt.Extensions
{
    public static class SizeExtensions
    {
        public static bool IsSmallerThan(this Size _size, Size size)
        {
            bool rowsBound = _size.Rows >= size.Rows;
            bool columnsBound = _size.Columns >= size.Columns;

            return rowsBound && columnsBound;
        }
    }
}
