namespace LeapYearTests
{
    public static class Year
    {
        public static bool IsLeapYear(int year)
        {
            return year.IsDivisibleBy(4) && !IsAtypicalCommonYear(year);
        }

        private static bool IsAtypicalCommonYear(int year)
        {
            return year.IsDivisibleBy(100) && !year.IsDivisibleBy(400);
        }
    }
}