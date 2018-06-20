using System;
using System.Linq;
using core;

namespace encode
{
    class Program
    {
        static int Main(string[] args)
        {
            if (args.Count() < 2)
            {
                Console.WriteLine("Usage: encode key input");
                return 1;
            }

            var key = args[0].ToLower();
            var input = args[1].ToLower();
            var cipher = new AlphabetCipher();
            Console.WriteLine(cipher.Encode(input, key));

            return 0;
        }
    }
}
