using core;
using Xunit;

namespace coretests
{
    public class CreateKeyString
    {
        private readonly AlphabetCipher _sut = new AlphabetCipher("test");

        [Theory]
        [InlineData("abx", 3, "abx")]
        [InlineData("xyz", 5, "xyzxy")]
        [InlineData("key", 6, "keykey")]
        public void Create_correct_key_string(string key, int length, string expected)
        {
            var result = _sut.CreateKeyString(key, length);
            Assert.Equal(length, result.Length);
            Assert.Equal(expected, result);
        }
    }
}