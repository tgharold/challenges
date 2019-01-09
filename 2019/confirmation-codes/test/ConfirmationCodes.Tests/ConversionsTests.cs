using ConfirmationCodes;
using Xunit;

namespace ConfirmationCodes.Tests
{
    public class ConversionsTests
    {
        public class RepresentationToValueTests : ConversionsTests
        {
            [Theory]
            [InlineData("0", 0)]
            [InlineData("3", 3)]
            [InlineData("A", 10)]
            [InlineData("F", 15)]
            [InlineData("FF", 255)]
            [InlineData("ABCDEF", 11259375)]
            public void Base16Hexadecimal(string input, long expected)
            {
                var result = Conversions.RepresentationToValue(input, Constants.Base16Hexadecimal);
                Assert.Equal(expected, result);
            }

            [Theory]
            [InlineData("0", 0)]
            [InlineData("1", 1)]
            [InlineData("10", 2)]
            [InlineData("010", 2)]
            [InlineData("011", 3)]
            [InlineData("11011001110111011101010101011", 456899243)]
            public void Base2Binary(string input, long expected)
            {
                var result = Conversions.RepresentationToValue(input, Constants.Base2Binary);
                Assert.Equal(expected, result);
            }
        }

        public class ValueToRepresentationTests : ConversionsTests
        {
            [Theory]
            [InlineData(3, "11")]
            [InlineData(456899243, "11011001110111011101010101011")]
            public void Base2Binary(long input, string expected)
            {
                var result = Conversions.ValueToRepresentation(input, Constants.Base2Binary);
                Assert.Equal(expected, result);
            }
        }

        public class BaseToBaseTests : ConversionsTests
        {
            [Theory]
            [InlineData("11011001110111011101010101011")]
            public void Base2Binary_to_Base2Binary(string expected)
            {
                var result = Conversions.BaseToBase(expected, Constants.Base2Binary, Constants.Base2Binary);
                Assert.Equal(expected, result);
            }

            [Theory]
            [InlineData("011", "3")]
            [InlineData("101001110101010111011010101", "53AAED5")]
            public void Base2Binary_to_Base16Hexadecimal(string input, string expected)
            {
                var result = Conversions.BaseToBase(input, Constants.Base2Binary, Constants.Base16Hexadecimal);
                Assert.Equal(expected, result);
            }
        }
    }
}