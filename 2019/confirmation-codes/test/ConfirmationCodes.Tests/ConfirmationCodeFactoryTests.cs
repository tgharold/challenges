using System;
using System.Security.Cryptography;
using Xunit;

namespace ConfirmationCodes
{
    public class ConfirmationCodeFactoryTests
    {
        private readonly RandomNumberGenerator _rng;

        public ConfirmationCodeFactoryTests()
        {
            _rng = RandomNumberGenerator.Create();
        }

        [Theory]
        [InlineData(1)]
        [InlineData(5)]
        [InlineData(15)]
        public void GenerateProperNumberOfHexadecimalDigits(int digits)
        {
            var sut = new ConfirmationCodeFactory(Constants.Base16Hexadecimal, Constants.BadEnglishWords, _rng);
            var code = sut.Generate(digits);
            Assert.Equal(digits, code.Length);
        }
    }
}
