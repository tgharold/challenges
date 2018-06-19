using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace core
{
    public class AlphabetCipher : ICipherInterface
    {
        private int _alphabetSize;
        private char[] _alphabet;
        private char[,] _substitutionArray;

        public AlphabetCipher(
            string alphabet = "abcdefghijklmnopqrstuvwxyz"
            )
        {
            if (string.IsNullOrEmpty(alphabet))
                throw new ArgumentNullException(alphabet);

            _alphabetSize = alphabet.Length;
            if (_alphabetSize < 1 || _alphabetSize > 200)
                throw new ArgumentException(
                    nameof(alphabet),
                    "Must be length 1-200."
                );
            _substitutionArray = new char[_alphabetSize,_alphabetSize];
            _alphabet = alphabet.ToCharArray();
            SetupSubstitutionArray();
        }

        private void SetupSubstitutionArray()
        {
            for(var y = 0; y < _alphabetSize; y++)
            {
                for(var x = 0; x < _alphabetSize; x++)
                {
                    _substitutionArray[x,y] = _alphabet[(x+y)%_alphabetSize];
                }
            }
        }

        public IEnumerable<string> GetSubstitutionArray()
        {
            var result = new List<string>();
            for(var y = 0; y < _alphabetSize; y++)
            {
                var stringBuilder = new StringBuilder();
                for(var x = 0; x < _alphabetSize; x++)
                {
                    var c = _substitutionArray[x,y];
                    stringBuilder.Append(c);
                }
                result.Add(stringBuilder.ToString());
            }
            return result;;
        }

        public char Encode(char inputChar, char keyChar)
        {
            var x = _alphabet.FirstOrDefault(c => c == keyChar);
            if (x == default(char)) return inputChar;
            var y = _alphabet.FirstOrDefault(c => c == inputChar);
            if (y == default(char)) return inputChar;
            return _substitutionArray[x,y];
        }

        public char[] CreateKeyArray(string key)
        {
            return null;
        }

        public string Encode(string input, string key)
        {
            var inputChars = input.ToCharArray();

            throw new NotImplementedException();
        }

        public string Decode(string input, string key)
        {
            throw new NotImplementedException();
        }
    }
}
