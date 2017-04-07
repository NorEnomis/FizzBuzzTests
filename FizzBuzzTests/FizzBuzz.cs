using System;

namespace FizzBuzzTests
{
    public static class FizzBuzz
    {
        public static string Translate(int number)
        {
            string result = string.Empty;
            if (number.IsDivisibleBy(3))
            {
                result = "fizz";
            }
            if (number.IsDivisibleBy(5))
            {
                result += "buzz";
            }
            return IsDefault(result) ? HandleDefault(number) : result;
        }

        private static bool IsDefault(string result)
        {
            return string.IsNullOrEmpty(result);
        }

        private static string HandleDefault(int number)
        {
            return Convert.ToString(number);
        }
    }
}