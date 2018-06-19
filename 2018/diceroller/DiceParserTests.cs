using System.Linq;
using Xunit;

namespace diceroller
{
    public class DiceParserTests
    {
        [Fact]
        public void Can_parse_null()
        {
            var result = DiceParser.GetDice(null);
            Assert.NotNull(result);
        }

        [Fact]
        public void Can_parse_empty_string()
        {
            var result = DiceParser.GetDice("");
            Assert.NotNull(result);
        }

        [Theory]
        [InlineData("1d4", 1)]
        [InlineData("2d6", 2)]
        [InlineData("3d8", 3)]
        [InlineData("4d20", 4)]
        public void Returns_the_correct_count_of_dice(string input, int expectedCount)
        {
            var result = DiceParser.GetDice(input);
            Assert.Equal(expectedCount, result.Count());
        }
    }
}