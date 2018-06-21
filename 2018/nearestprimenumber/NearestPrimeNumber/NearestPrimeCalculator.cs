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
            throw new NotImplementedException();
        }

        public long Ceiling(long input)
        {
            throw new NotImplementedException();
        }
    }
}
