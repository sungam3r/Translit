﻿using Xunit;

namespace NickBuhro.Translit.Tests
{
    public sealed partial class TransliterationTests
    {
        private static void CyrillycToLatinTest(
            Language lang,
            string source, 
            string expectedResult)
        {
            var actual = Transliteration.CyrillicToLatin(source, lang);
            Assert.Equal(expectedResult, actual);
        }
        
        private static void LatinToCyrillicTest(
            Language lang,
            string source,
            string expectedResult)
        {
            var actual = Transliteration.LatinToCyrillyc(source, lang);
            Assert.Equal(expectedResult, actual);
        }

        private static void RoundTest(
            Language lang,
            string source)
        {
            var latin = Transliteration.CyrillicToLatin(source, lang);
            var actual = Transliteration.LatinToCyrillyc(latin, lang);
            Assert.Equal(source, actual);
        }
    }
}