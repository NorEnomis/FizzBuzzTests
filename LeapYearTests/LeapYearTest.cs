using NUnit.Framework;

namespace LeapYearTests
{
    public class LeapYearTest
    {
        [TestCase(2001, false)]
        public void Should_return_false_when_typical_common_year(int year, bool expected)
        {
            Assert.That(Year.IsLeapYear(year), Is.EqualTo(expected));
        }

        [TestCase(1900, false)]
        public void Should_return_false_when_atypical_common_year(int year, bool expected)
        {
            Assert.That(Year.IsLeapYear(year), Is.EqualTo(expected));
        }

        [TestCase(1996, true)]
        public void Should_return_true_when_typical_leap_year(int year, bool expected)
        {
            Assert.That(Year.IsLeapYear(year), Is.EqualTo(expected));
        }

        [TestCase(2000, true)]
        public void Should_return_true_when_atypical_leap_year(int year, bool expected)
        {
            Assert.That(Year.IsLeapYear(year), Is.EqualTo(expected));
        }
    }
}
