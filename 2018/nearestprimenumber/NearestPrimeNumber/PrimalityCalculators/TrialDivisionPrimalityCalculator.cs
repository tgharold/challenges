using System;

namespace NearestPrimeNumber.PrimalityCalculators
{
    public class TrialDivisionPrimalityCalculator : IPrimalityCalculator
    {
        public bool IsPrime(long input)
        {
            if (input < 1) throw new ArgumentOutOfRangeException(nameof(input), "Must be > 0");
            if (input <= 3) return true;

            var sqrt = (int) Math.Floor(Math.Sqrt(input));
            var arraySize = ((int) (sqrt/2));
            var array = new bool[arraySize];

            for (var i = 3; i <= sqrt; i += 2)
            {
                
            }

            return true;
        }
    }
}
