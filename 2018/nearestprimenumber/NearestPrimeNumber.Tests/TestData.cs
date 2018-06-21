using System;
using System.Collections.Generic;
using Xunit;

namespace NearestPrimeNumber.Tests
{
    public class TestData
    {
    public static IReadOnlyCollection<object[]> TinyPrimes =>
        new []
        {
            new object[] { 1, true },
            new object[] { 2, true },
            new object[] { 3, true },
            new object[] { 4, false },
            new object[] { 5, true },
            new object[] { 6, false },
            new object[] { 7, true },
            new object[] { 8, false },
            new object[] { 9, false },
        };
    }
}
