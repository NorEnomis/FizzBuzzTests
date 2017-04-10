using NUnit.Framework;

namespace CreditCardMaskTests
{
    [TestFixture]
    public class CreditCardMaskTest
    {
        [Test]
        public void Should_mask_nothing_when_empty()
        {
            Assert.That(Maskify.Mask(string.Empty), Is.EqualTo(string.Empty));
        }

        [TestCase("1", "1")]
        [TestCase("12", "12")]
        [TestCase("123", "123")]
        [TestCase("1234", "1234")]
        public void Should_mask_nothing_when_less_or_equal_to_4_characters(string input, string result)
        {
            Assert.That(Maskify.Mask(input), Is.EqualTo(result));
        }

        [TestCase("12345", "#2345")]
        [TestCase("123456", "##3456")]
        [TestCase("4556364607935616", "############5616")]
        public void Should_mask_all_except_last_four_characters(string input, string result)
        {
            Assert.That(Maskify.Mask(input), Is.EqualTo(result));
        }
    }

    public static class Maskify
    {
        public static string Mask(string input)
        {
            int lengthInput = input.Length;
            const int numberOfVisibleCharacters = 4;
            const char maskedCharacter = '#';
            return lengthInput <= numberOfVisibleCharacters ? input : input.Substring(lengthInput - numberOfVisibleCharacters).PadLeft(lengthInput, maskedCharacter);
        }
    }
}
