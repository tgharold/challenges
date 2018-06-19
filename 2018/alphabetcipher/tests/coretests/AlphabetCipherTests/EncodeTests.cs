using core;
using Xunit;

namespace coretests.AlphabetCipherTests
{
    public class EncodeTests
    {
        private ICipherInterface _sut;

        public EncodeTests()
        {
            _sut = new AlphabetCipher();
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
    }
}