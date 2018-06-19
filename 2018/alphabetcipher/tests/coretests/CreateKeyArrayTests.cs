using core;
using Xunit;

namespace coretests
{
    public class CreateKeyArrayTests
    {
        private readonly AlphabetCipher _sut = new AlphabetCipher("test");

        [Theory]
        [InlineData("key", 6, "keykey")]
        public void Create_correct_key_array(string key, int length, string expected)
        {
            var result = _sut.CreateKeyArray(key).ToString();
            Assert.Equal(length, result.Length);
            Assert.Equal(expected, result);
        }
    }
}