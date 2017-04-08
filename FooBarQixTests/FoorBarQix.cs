using System.Collections.Generic;
using System.Globalization;

namespace FooBarQixTests
{
    public static class FoorBarQix
    {
        private static readonly Dictionary<int, string> TranslationRules = new Dictionary<int, string>
        {
            {3, "Foo" },
            {5, "Bar" },
            {7, "Qix" }
        };

        public static string Translate(int number)
        {
            string defaultTranslation = number.ToString(CultureInfo.InvariantCulture);
            string translation = string.Empty;
            translation = HandleDivisible(number, translation);
            translation = HandleContain(number, translation);
            return string.IsNullOrEmpty(translation) ? defaultTranslation : translation;
        }

        private static string HandleContain(int number, string translation)
        {
            foreach (char source in number.ToString(CultureInfo.InvariantCulture))
            {
                foreach (int figure in TranslationRules.Keys)
                {
                    char target = figure.ToString(CultureInfo.InvariantCulture)[0];
                    if (source.Equals(target))
                    {
                        translation += TranslationRules[figure];
                    }
                }
            }
            return translation;
        }

        private static string HandleDivisible(int number, string translation)
        {
            foreach (int figure in TranslationRules.Keys)
            {
                if (number.IsDivisibleBy(figure))
                {
                    translation += TranslationRules[figure];
                }
            }
            return translation;
        }
    }
}