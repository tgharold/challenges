using System;

namespace NearestPrimeNumber
{
    public class NearestPrimeCalculator
    {
        private IPrimalityCalculator _primalityCalculator;

        public NearestPrimeCalculator(IPrimalityCalculator primalityCalculator)
        {
            _primalityCalculator = primalityCalculator;
        }

        public long Floor(long input)
        {
            if (input < 1) throw new ArgumentOutOfRangeException(nameof(input), "Must be > 0");
            if (input > Int32.MaxValue)  throw new ArgumentOutOfRangeException(nameof(input), $"Must be <= {Int32.MaxValue}");
            if (input <= 3) return input; // handles the trivial cases

            var candidate = input;
            while(!_primalityCalculator.IsPrime(candidate))
            {
                candidate -= (input % 2 == 0) ? 1 : 2;
            }
            return candidate;
        }

        public long Ceiling(long input)
        {
            if (input < 1) throw new ArgumentOutOfRangeException(nameof(input), "Must be > 0");
            if (input > Int32.MaxValue)  throw new ArgumentOutOfRangeException(nameof(input), $"Must be <= {Int32.MaxValue}");
            if (input <= 3) return input; // handles the trivial cases

            var candidate = input;
            while(!_primalityCalculator.IsPrime(candidate))
            {
                candidate += (input % 2 == 0) ? 1 : 2;
            }
            return candidate;
        }
    }
}
