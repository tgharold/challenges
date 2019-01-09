using System;
using System.Numerics;
using System.Security.Cryptography;

namespace ConfirmationCodes
{
    public class ConfirmationCodeFactory
    {
        private string _characterSet;
        private long _base;
        private string[] _badWordFragments = new string[]{ };
        private RandomNumberGenerator _rng;

        public ConfirmationCodeFactory(
            string characterSet,
            string[] badWordFragments,
            RandomNumberGenerator rng
            )
        {
            _characterSet = characterSet;
            _base = _characterSet.Length;
            _badWordFragments = badWordFragments;
            _rng = rng;
        }   

        public string Generate(int length)
        {
            BigInteger maximumValue = _base * length;
            //TODO: calculate bytes needed using a log_base() function
            var bytesNeeded = Conversions.BaseToBase(maximumValue.ToString(), Constants.Base10Decimal, Constants.Base16Hexadecimal).Length / 2 + 1;
            byte[] bytes = new Byte[bytesNeeded];
            _rng.GetBytes(bytes);
            var value = new BigInteger(bytes);
            var rawOutput = Conversions.BaseToBase(value.ToString(), Constants.Base10Decimal, _characterSet);
            return rawOutput.Substring(0, length);
        }
    }
}
