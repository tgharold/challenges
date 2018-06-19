using System;
using System.Linq;

namespace diceroller
{
    class Program
    {
        public static Random Random = new Random();

        static void Main(string[] args)
        {
            var input = string.Join(",", args);
            Console.WriteLine($"input: {input}");
            var dice = DiceParser.GetDice(input).ToList();
            Console.WriteLine($"number of dice: {dice?.Count}");
            var result = DiceParser.RollDice(dice);
            Console.WriteLine($"result: {result}");

            Console.WriteLine();
        }
    }
}
