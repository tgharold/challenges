using System;
using System.Linq;

namespace diceroller
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = "3d6";
            Console.WriteLine($"input: {input}");
            var result = DiceParser.GetDice(input).ToList();
            Console.WriteLine($"count: {result?.Count}");

            Console.WriteLine("Hello World!");
        }
    }
}
