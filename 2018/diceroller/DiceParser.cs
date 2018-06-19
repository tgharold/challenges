using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace diceroller
{
    public static class DiceParser
    {
        private const string _diceRegexPattern = @"([0-9]{1,3}[dD]{1}[0-9]{1,3})";

        public static IEnumerable<Die> GetDice(string input)
        {
            var result = new List<Die>();
            if (string.IsNullOrEmpty(input)) return result;

            MatchCollection matches = Regex.Matches(input, _diceRegexPattern);
            foreach(Match match in matches)
            {
                foreach(Capture capture in match.Captures)
                result.AddRange(ParseDiceDefinition(capture.Value));
            }

            return result;
        }

        public static int RollDice(IEnumerable<Die> dice)
        {
            var result = 0;
            foreach(var die in dice) result += RollDie(die);
            return result;
        }

        private static int RollDie(Die die)
        {
            //TODO: Use IoC to inject something looking like Random
            return Program.Random.Next(die.Sides) + 1;
        }

        private static IEnumerable<Die> ParseDiceDefinition(string element)
        {
            var elements = Regex.Split(element, "[dD]{1}");
            var count = int.Parse(elements[0]);
            var sides = int.Parse(elements[1]);
            return CreateDice(count, sides);   
        }

        private static IEnumerable<Die> CreateDice(int count, int sides)
        {
            var result = new List<Die>();
            for (var i = 0; i < count; i++)
            {
                result.Add(new Die(sides));
            }
            return result;
         }
    }
}