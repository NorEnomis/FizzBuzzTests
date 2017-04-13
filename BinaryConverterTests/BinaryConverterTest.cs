using System;
using NUnit.Framework;

namespace BinaryConverterTests
{
    [TestFixture]
    public class BinaryConverterTest
    {
        [Test]
        public void Should_return_0_when_array_only_contains_0()
        {
            int[] input = {0, 0, 0, 0};
            int result = BinaryConverter.ConvertToNumber(input);
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void Should_return_1_when_array_contains_three_0_and_one_1()
        {
            int[] input = { 0, 0, 0, 1 };
            int result = BinaryConverter.ConvertToNumber(input);
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void Should_return_2_when_array_contains_two_0_one_1_and_one_0()
        {
            int[] input = { 0, 0, 1, 0 };
            int result = BinaryConverter.ConvertToNumber(input);
            Assert.That(result, Is.EqualTo(2));
        }

        [TestCase(new[] { 0, 1, 0, 1 }, 5)]
        [TestCase(new[] { 1, 0, 0, 1 }, 9)]
        [TestCase(new[] { 1, 1, 1, 1 }, 15)]
        public void Should_return_number(int[] input, int result)
        {
            Assert.That(BinaryConverter.ConvertToNumber(input), Is.EqualTo(result));
        }
    }

    public static class BinaryConverter
    {
        public static int ConvertToNumber(int[] input)
        {
            return Convert.ToInt32(string.Join("", input), 2);
        }
    }
}
