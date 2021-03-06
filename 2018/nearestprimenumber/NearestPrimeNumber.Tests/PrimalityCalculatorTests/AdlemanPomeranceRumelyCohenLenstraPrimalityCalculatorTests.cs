using System;
using System.Collections.Generic;
using NearestPrimeNumber.PrimalityCalculators;
using Xunit;

namespace NearestPrimeNumber.Tests.PrimalityCalculatorTests
{
    public class AdlemanPomeranceRumelyCohenLenstraPrimalityCalculatorTests
    {
        private readonly IPrimalityCalculator _sut;

        public static readonly IReadOnlyCollection<object[]> TinyPrimes = TestData.TinyPrimes;
        public static readonly IReadOnlyCollection<object[]> SmallPrimes = TestData.SmallPrimes;

        public AdlemanPomeranceRumelyCohenLenstraPrimalityCalculatorTests()
        {
            _sut = new AdlemanPomeranceRumelyCohenLenstraPrimalityCalculator();
        }

        [Theory]
        [MemberData(nameof(TinyPrimes))]
        public void Test_TinyPrimes(long input, bool expected)
        {
            var result = _sut.IsPrime(input);
            TestHelpers.AssertResultMatchesExpectation(input, expected, result);
        }

        [Theory]
        [MemberData(nameof(SmallPrimes))]
        public void Test_SmallPrimes(long input, bool expected)
        {
            var result = _sut.IsPrime(input);
            TestHelpers.AssertResultMatchesExpectation(input, expected, result);
        }
    }
}
