using System.Collections.Generic;
using System.Linq;

namespace PrimeFactorsTests
{
    public static class StringExtension
    {
        public static List<int> ToListOfInt(this string expected)
        {
            return expected.Split(',').Select(int.Parse).ToList();
        }
    }
}