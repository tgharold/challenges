using System;
using System.Numerics;
using System.Security.Cryptography;

namespace ConfirmationCodes
{
    public class ConfirmationCodeFactory
    {
        private string _characterSet;
        private string[] _badWordFragments = new string[]{ };
        private RandomNumberGenerator _rng;

        public ConfirmationCodeFactory(
            string characterSet,
            string[] badWordFragments,
            RandomNumberGenerator rng
            )
        {
            _characterSet = characterSet;
            _badWordFragments = badWordFragments;
            _rng = rng;
        }   

    }
}
