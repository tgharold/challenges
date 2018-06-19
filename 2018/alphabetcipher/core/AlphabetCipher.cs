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

            var duplicates = _alphabet
                .GroupBy(x => x)
                .Where(group => group.Count() > 1)
                .Select(group => group.Key)
                .ToList()
                ;
            if (duplicates.Any())
                throw new ArgumentException(
                  nameof(alphabet),
                  $"Found duplicate characters: '{string.Join(",",duplicates)}'."  
                );

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
            var x = Array.FindIndex(_alphabet, c => c == keyChar);
            if (x == default(char)) return inputChar;
            var y = Array.FindIndex(_alphabet, c => c == inputChar);
            if (y == default(char)) return inputChar;
            return _substitutionArray[x,y];
        }

        public string CreateKeyString(string key, int length)
        {
            var stringBuilder = new StringBuilder();
            var keyLength = key.Length;
            var iterations = (length / keyLength);
            stringBuilder.Append(key);
            for (var i = 0; i < iterations; i++)
            {
                stringBuilder.Append(key);
            }
            var result = stringBuilder.ToString();
            return result.Substring(0, length);
        }

        public string Encode(string input, string key)
        {
            var inputChars = input.ToCharArray();
            var keyChars = CreateKeyString(key, input.Length).ToCharArray();
            var stringBuilder = new StringBuilder();

            for(var i = 0; i < inputChars.Length; i++)
            {
                stringBuilder.Append(Encode(inputChars[i], keyChars[i]));
            }
            return stringBuilder.ToString();
        }

        public string Decode(string input, string key)
        {
            throw new NotImplementedException();
        }
    }
}
