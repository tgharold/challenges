using System.Linq;
using core;
using Xunit;

namespace coretests.AlphabetCipherTests
{
    public class SubstitutionArrayTests
    {
        [Theory]
        [InlineData("abcdefghijklmnopqrstuvwxyz", 26)]
        public void Creates_array_with_correct_counts(string alphabet, int expected)
        {
            var sut = new AlphabetCipher(alphabet);
            var results = sut.GetSubstitutionArray().ToList();
            Assert.Equal(expected, results.Count());
            foreach(var result in results)
            {
                Assert.Equal(expected, result.Length);
            }
        }

        [Theory]
        [InlineData("abcdefghijklmnopqrstuvwxyz", 0, "abcdefghijklmnopqrstuvwxyz")]
        [InlineData("abcdefghijklmnopqrstuvwxyz", 3, "defghijklmnopqrstuvwxyzabc")]
        public void Array_row_is_correct(string alphabet, int rowIndex, string expected)
        {
            var sut = new AlphabetCipher(alphabet);
            var results = sut.GetSubstitutionArray().ToArray();
            var result = results[rowIndex];
            Assert.Equal(expected, result);
        }
    }
}