using core;
using Xunit;

namespace coretests.AlphabetCipherTests
{
    public class EncodeTests
    {
        private const string _alphabet = "abcdefghijklmnopqrstuvwxyz";
        private ICipherInterface _sut;

        public EncodeTests()
        {
            _sut = new AlphabetCipher(_alphabet);
        }

        [Theory]
        [InlineData("snitch", "thepackagehasbeendelivered", "lumicjcnoxjhkomxpkwyqogywq")]
        [InlineData("bond", "theredfoxtrotsquietlyatmidnight", "uvrufrsryherugdxjsgozogpjralhvg")]
        [InlineData("train", "murderontheorientexpress", "flrlrkfnbuxfrqrgkefckvsa")]
        [InlineData("garden", "themolessnuckintothegardenlastnight", "zhvpsyksjqypqiewsgnexdvqkncdwgtixkx")]
        [InlineData("cloak", "iamtheprettiestunicorn", "klatrgafedvtssdwywcyty")]
        [InlineData("python", "alwayslookonthebrightsideoflife", "pjphmfamhrcaifxifvvfmzwqtmyswst")]
        [InlineData("moore", "foryoureyesonly", "rcfpsgfspiecbcc")]
        public void Test_encoder(string key, string input, string expected)
        {
            var result = _sut.Encode(input, key);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(_alphabet, 'p', 'a', 'p')]
        [InlineData(_alphabet, 's', 't', 'l')]
        [InlineData(_alphabet, 'v', 'm', 'h')]
        [InlineData(_alphabet, 'i', 'e', 'm')]
        [InlineData(_alphabet, 'g', 'e', 'k')]
        [InlineData(_alphabet, 'i', 't', 'b')]
        [InlineData(_alphabet, 'l', 'm', 'x')]
        [InlineData(_alphabet, 'a', 'e', 'e')]
        [InlineData(_alphabet, 'n', 'o', 'b')]
        [InlineData(_alphabet, 'c', 'n', 'p')]
        [InlineData(_alphabet, 'e', 't', 'x')]
        public void Encode_does_correct_substitution(
            string alphabet, 
            char keyChar,
            char inputChar,
            char expected
            )
        {
            var sut = new AlphabetCipher(alphabet);
            var result = sut.Encode(inputChar, keyChar);
            Assert.Equal(expected, result);
        }
    }
}