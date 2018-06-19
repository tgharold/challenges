using System;
using System.Collections.Generic;
using System.Text;

namespace core
{
    public class AlphabetCipher : ICipherInterface
    {
        private int _alphabetSize;
        private string _startingRow;
        private char[,] _substitutionArray;

        public AlphabetCipher(
            string startingRow = "abcdefghijklmnopqrstuvwxyz"
            )
        {
            if (string.IsNullOrEmpty(startingRow))
                throw new ArgumentNullException(startingRow);

            _alphabetSize = startingRow.Length;
            if (_alphabetSize < 1 || _alphabetSize > 200)
                throw new ArgumentException(
                    nameof(startingRow),
                    "Must be length 1-200."
                );
            _substitutionArray = new char[_alphabetSize,_alphabetSize];
            _startingRow = startingRow;
            SetupSubstitutionArray();
        }

        private void SetupSubstitutionArray()
        {
            var startRow = _startingRow.ToCharArray();
            for(var y = 0; y < _alphabetSize; y++)
            {
                for(var x = 0; x < _alphabetSize; x++)
                {
                    _substitutionArray[x,y] = startRow[x];
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
        
        public string Encode(string input, string key)
        {
            throw new NotImplementedException();
        }

        public string Decode(string input, string key)
        {
            throw new NotImplementedException();
        }
    }
}
