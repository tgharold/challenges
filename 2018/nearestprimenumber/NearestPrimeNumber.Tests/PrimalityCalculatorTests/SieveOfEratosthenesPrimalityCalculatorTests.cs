using System;
using System.Collections.Generic;
using NearestPrimeNumber.PrimalityCalculators;
using Xunit;

namespace NearestPrimeNumber.Tests.PrimalityCalculatorTests
{
    public class SieveOfEratosthenesPrimalityCalculatorTests
    {
        private IPrimalityCalculator _sut;

        public static readonly IReadOnlyCollection<object[]> TinyPrimes = TestData.TinyPrimes;

        public SieveOfEratosthenesPrimalityCalculatorTests()
        {
            _sut = new SieveOfEratosthenesPrimalityCalculator();
        }

        [Theory]
        [MemberData(nameof(TestData.TinyPrimes))]
        public void Test1(long input, bool expected)
        {
            Assert.Equal(expected, _sut.IsPrime(input));
        }
    }
}
