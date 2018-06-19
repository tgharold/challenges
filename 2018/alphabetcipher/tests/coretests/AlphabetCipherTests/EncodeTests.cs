using Xunit;

namespace coretests.AlphabetCipherTests
{
    public class EncodeTests
    {
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

        }
    }
}