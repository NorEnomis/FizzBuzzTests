using NUnit.Framework;

namespace FooBarQixTests
{
    [TestFixture]
    public class FooBarQixTest
    {
        [TestCase(6, "Foo")]
        [TestCase(13, "Foo")]
        public void Should_print_Foo_when_number_divisible_by_3_and_not_contains_3(int number, string expected)
        {
            Assert.That(FoorBarQix.Translate(number), Is.EqualTo(expected));
        }

        [Test]
        public void Should_print_FooFoo_when_number_divisible_by_3_and_contains_3()
        {
            Assert.That(FoorBarQix.Translate(3), Is.EqualTo("FooFoo"));
        }

        [Test]
        public void Should_print_BarBar_when_number_divisible_by_5_and_contains_5()
        {
            Assert.That(FoorBarQix.Translate(5), Is.EqualTo("BarBar"));
        }

        [Test]
        public void Should_print_Bar_when_number_divisible_by_5_and_not_contains_5()
        {
            Assert.That(FoorBarQix.Translate(10), Is.EqualTo("Bar"));
        }

        [Test]
        public void Should_print_QixQix_when_number_divisible_by_7_and_contains_7()
        {
            Assert.That(FoorBarQix.Translate(7), Is.EqualTo("QixQix"));
        }

        [Test]
        public void Should_print_FooBar_when_number_divisible_by_3_and_contains_5()
        {
            Assert.That(FoorBarQix.Translate(51), Is.EqualTo("FooBar"));
        }

        [Test]
        public void Should_print_FooBarBar_when_number_divisible_by_3_5_and_contains_5()
        {
            Assert.That(FoorBarQix.Translate(15), Is.EqualTo("FooBarBar"));
        }

        [Test]
        public void Should_print_FooFooFoo_when_number_divisible_by_3_and_contains_3_2_times()
        {
            Assert.That(FoorBarQix.Translate(33), Is.EqualTo("FooFooFoo"));
        }

        [Test]
        public void Should_print_BarFoor_when_contains_5_and_then_3()
        {
            Assert.That(FoorBarQix.Translate(53), Is.EqualTo("BarFoo"));
        }

        [Test]
        public void Should_print_Qix_when_number_divisible_by_7_and_not_contains_7()
        {
            Assert.That(FoorBarQix.Translate(14), Is.EqualTo("Qix"));
        }

        [TestCase(1, "1")]
        [TestCase(2, "2")]
        [TestCase(4, "4")]
        public void Should_print_number_when_number_not_divisible_by_3_5_7_and_not_contains_3_5_7(int number, string expected)
        {
            Assert.That(FoorBarQix.Translate(number), Is.EqualTo(expected));
        }
    }
}
