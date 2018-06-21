using System;
using System.Collections.Generic;
using NearestPrimeNumber.PrimalityCalculators;
using Xunit;

namespace NearestPrimeNumber.Tests.PrimalityCalculatorTests
{
    public class TrialDivisionPrimalityCalculatorTests
    {
        private readonly IPrimalityCalculator _sut;

        public static readonly IReadOnlyCollection<object[]> TinyPrimes = TestData.TinyPrimes;

        public TrialDivisionPrimalityCalculatorTests()
        {
            _sut = new TrialDivisionPrimalityCalculator();
        }

        [Theory]
        [MemberData(nameof(TestData.TinyPrimes))]
        public void Test1(long input, bool expected)
        {
            var result = _sut.IsPrime(input);
            Assert.True(
                expected==result,
                $"Input: {input}, Expected: {expected}, Result: {result}"
            );
        }
    }
}
