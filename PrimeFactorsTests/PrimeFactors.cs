using System.Collections.Generic;

namespace PrimeFactorsTests
{
    public static class PrimeFactors
    {
        public static List<int> Generate(int input)
        {
            var primeFactors = new List<int>();
            for (int candidate = 2; input > 1; candidate++)
            {
                for (; input % candidate == 0; input /= candidate)
                {
                    primeFactors.Add(candidate);
                }
            }
            return primeFactors;
        }
    }
}