using NUnit.Framework;

namespace FizzBuzzTests
{
    public class FizzBuzzTest
    {
        [TestCase(3, "fizz")]
        [TestCase(6, "fizz")]
        [TestCase(9, "fizz")]
        public void Should_replace_number_by_fizz_when_divisible_by_3(int number, string expected)
        {
            Assert.That(FizzBuzz.Translate(number), Is.EqualTo(expected));
        }

        [TestCase(5, "buzz")]
        [TestCase(10, "buzz")]
        public void Should_replace_number_by_buzz_when_divisible_by_5(int number, string expected)
        {
            Assert.That(FizzBuzz.Translate(number), Is.EqualTo(expected));
        }

        [TestCase(15, "fizzbuzz")]
        [TestCase(30, "fizzbuzz")]
        public void Should_replace_number_by_fizzbuzz_when_divisible_by_3_and_5(int number, string expected)
        {
            Assert.That(FizzBuzz.Translate(number), Is.EqualTo(expected));
        }

        [TestCase(1, "1")]
        [TestCase(2, "2")]
        [TestCase(4, "4")]
        public void Should_return_number_when_neither_divisible_by_3_nor_5(int number, string expected)
        {
            Assert.That(FizzBuzz.Translate(number), Is.EqualTo(expected));
        }
    }
}
