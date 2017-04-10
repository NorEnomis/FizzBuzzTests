using System.Linq;
using NUnit.Framework;

namespace PalindromeTests
{
    [TestFixture]
    public class PalindromeTest
    {
        [Test]
        public void Should_return_true_when_empty_string()
        {
            Assert.That(Palindrome.IsPalindrome(string.Empty), Is.EqualTo(true));
            Assert.That(Palindrome.IsPalindromeInRecursive(string.Empty), Is.EqualTo(true));

        }

        [Test]
        public void Should_return_true_when_one_character()
        {
            Assert.That(Palindrome.IsPalindrome("a"), Is.EqualTo(true));
            Assert.That(Palindrome.IsPalindromeInRecursive("a"), Is.EqualTo(true));
        }

        [Test]
        public void Should_return_false_when_two_characters()
        {
            Assert.That(Palindrome.IsPalindrome("ab"), Is.EqualTo(false));
            Assert.That(Palindrome.IsPalindromeInRecursive("ab"), Is.EqualTo(false));
        }

        [TestCase("aba")]
        [TestCase("Abba")]
        [TestCase("iTopiNonAvevanoNipoti")]
        public void Should_return_true_when_string_read_from_left_to_right_equal_to_string_read_from_right_to_left(string input)
        {
            Assert.That(Palindrome.IsPalindrome(input), Is.EqualTo(true));
            Assert.That(Palindrome.IsPalindromeInRecursive(input), Is.EqualTo(true));
        }

        [TestCase("abc")]
        [TestCase("iGattiNonAvevanoCugini")]
        public void Should_return_false_when_string_read_from_left_to_right_not_equal_to_string_read_from_right_to_left(string input)
        {
            Assert.That(Palindrome.IsPalindrome(input), Is.EqualTo(false));
            Assert.That(Palindrome.IsPalindromeInRecursive(input), Is.EqualTo(false));
        }
    }

    public static class Palindrome
    {
        public static bool IsPalindrome(string input)
        {
            return input.Length <= 1 || input.ToLower() == string.Concat(input.ToLower().Reverse());
        }

        public static bool IsPalindromeInRecursive(string input)
        {
            return input.Length <= 1 ||
                (input.ToLower()[0] == input.ToLower()[input.Length - 1] && 
                    IsPalindromeInRecursive(input.Substring(1, input.Length - 2)));
        }
    }
}
