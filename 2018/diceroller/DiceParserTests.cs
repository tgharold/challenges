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
        [InlineData("13d20", 13)]
        [InlineData("25d4", 25)]
        public void Returns_the_correct_count_of_dice_for_simple_strings(
            string input, 
            int expectedCount
            )
        {
            var result = DiceParser.GetDice(input);
            Assert.Equal(expectedCount, result.Count());
        }

        [Theory]
        [InlineData("1d4 2d6", 3)]
        [InlineData("2d6\n3d8", 5)]
        [InlineData("25d4,3d8", 28)]
        [InlineData("4d20, 6d10, 5d8", 15)]
        [InlineData("13d20\t2d8", 15)]
        [InlineData("1d6\n25d4\t4d3\r5d6", 35)]
        public void Returns_the_correct_count_of_dice_for_complex_strings(
            string input, 
            int expectedCount
            )
        {
            var result = DiceParser.GetDice(input);
            Assert.Equal(expectedCount, result.Count());
        }

    }
}