namespace FizzBuzzTests
{
    public static class IntExtension
    {
        public static bool IsDivisibleBy(this int number, int modulo)
        {
            return number % modulo == 0;
        }
    }
}