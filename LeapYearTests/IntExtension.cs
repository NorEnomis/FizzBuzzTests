namespace LeapYearTests
{
    public static class IntExtenstion
    {
        public static bool IsDivisibleBy(this int year, int modulo)
        {
            return year % modulo == 0;
        }
    }
}