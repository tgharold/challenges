using System;
using System.Linq;
using core;

namespace decode
{
    class Program
    {
        static int Main(string[] args)
        {
            if (args.Count() < 2)
            {
                Console.WriteLine("Usage: decode key input");
                return 1;
            }

            var key = args[0].ToLower();
            var input = args[1].ToLower();
            var cipher = new AlphabetCipher();
            Console.WriteLine(cipher.Decode(input, key));

            return 0;
        }
    }
}
