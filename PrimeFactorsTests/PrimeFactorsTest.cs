using System.Collections.Generic;
using NUnit.Framework;

namespace PrimeFactorsTests
{
    [TestFixture]
    public class PrimeFactorsTest
    {
        [Test]
        public void Should_return_empty_list_when_input_equal_to_1()
        {
            Assert.That(PrimeFactors.Generate(1), Is.EqualTo(new List<int>()));
        }

        [TestCase(2, 2)]
        [TestCase(3, 3)]
        public void Should_return_input_when_prime_factor_input(int input, int expected)
        {
            Assert.That(PrimeFactors.Generate(input), Is.EqualTo(new List<int> { expected }));
        }

        [TestCase(4, "2, 2")]
        [TestCase(8, "2, 2, 2")]
        public void Should_return_list_of_2_when_multiple_of_2_input(int input, string expected)
        {
            Assert.That(PrimeFactors.Generate(input), Is.EqualTo(expected.ToListOfInt()));
        }

        [TestCase(9, "3, 3")]
        [TestCase(27, "3, 3, 3")]
        public void Should_return_list_of_3_when_multiple_of_3_input(int input, string expected)
        {
            Assert.That(PrimeFactors.Generate(input), Is.EqualTo(expected.ToListOfInt()));
        }

        [TestCase(25, "5, 5")]
        [TestCase(125, "5, 5, 5")]
        public void Should_return_list_of_5_when_multiple_of_5_input(int input, string expected)
        {
            Assert.That(PrimeFactors.Generate(input), Is.EqualTo(expected.ToListOfInt()));
        }

        [TestCase(6, "2, 3")]
        [TestCase(12, "2, 2, 3")]
        [TestCase(18, "2, 3, 3")]
        public void Should_return_list_of_2_and_3_when_multiple_of_2_and_3_input(int input, string expected)
        {
            Assert.That(PrimeFactors.Generate(input), Is.EqualTo(expected.ToListOfInt()));
        }
    }
}
