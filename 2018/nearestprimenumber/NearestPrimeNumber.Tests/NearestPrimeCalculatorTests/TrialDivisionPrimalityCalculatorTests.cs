using System;
using System.Collections.Generic;
using NearestPrimeNumber.PrimalityCalculators;
using NearestPrimeNumber.Tests;
using Xunit;

namespace NearestPrimeNumber.NearestPrimeCalculatorTests
{
    public class TrialDivisionPrimalityCalculatorTests
    {
        private NearestPrimeCalculator _sut;
        private IPrimalityCalculator _calculator;

        public static readonly IReadOnlyCollection<object[]> NearestTinyPrimePairs = TestData.NearestTinyPrimePairs;
        public static readonly IReadOnlyCollection<object[]> NearestSmallPrimePairs = TestData.NearestSmallPrimePairs;

        public TrialDivisionPrimalityCalculatorTests()
        {
            _calculator = new TrialDivisionPrimalityCalculator();
            _sut = new NearestPrimeCalculator(_calculator);
        }

        private long GetStartingPoint(long lowerPrime, long upperPrime)
        {
            AssertLowerUpperAreBothPrime(lowerPrime, upperPrime);
            var midPoint = (upperPrime - lowerPrime) / 2 + lowerPrime;
            Assert.True(lowerPrime < midPoint && midPoint < upperPrime, $"{lowerPrime} < {midPoint} < {upperPrime}");
            return midPoint;
        }

        private void AssertLowerUpperAreBothPrime(long lowerPrime, long upperPrime)
        {
            Assert.True(_calculator.IsPrime(lowerPrime));
            Assert.True(_calculator.IsPrime(upperPrime));
        }

        [Theory]
        [MemberData(nameof(NearestTinyPrimePairs))]
        public void Test_TinyPrimes_Floor(long lowerPrime, long upperPrime)
        {
            var start = GetStartingPoint(lowerPrime, upperPrime);
            var result = _sut.Floor(start);
            TestHelpers.AssertResultMatchesExpectation(lowerPrime, result);
        }

        [Theory]
        [MemberData(nameof(NearestTinyPrimePairs))]
        public void Test_TinyPrimes_Ceiling(long lowerPrime, long upperPrime)
        {
            var start = GetStartingPoint(lowerPrime, upperPrime);
            var result = _sut.Ceiling(start);
            TestHelpers.AssertResultMatchesExpectation(upperPrime, result);
        }

        [Theory]
        [MemberData(nameof(NearestSmallPrimePairs))]
        public void Test_SmallPrimes_Floor(long lowerPrime, long upperPrime)
        {
            var start = GetStartingPoint(lowerPrime, upperPrime);
            var result = _sut.Floor(start);
            TestHelpers.AssertResultMatchesExpectation(lowerPrime, result);
        }

        [Theory]
        [MemberData(nameof(NearestSmallPrimePairs))]
        public void Test_SmallPrimes_Ceiling(long lowerPrime, long upperPrime)
        {
            var start = GetStartingPoint(lowerPrime, upperPrime);
            var result = _sut.Ceiling(start);
            TestHelpers.AssertResultMatchesExpectation(upperPrime, result);
        }
    }
}
