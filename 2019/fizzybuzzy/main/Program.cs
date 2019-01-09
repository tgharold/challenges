using System;

namespace FizzyBuzzy
{
    public class Program
    {
        static void Main(string[] args)
        {
            for(var i=1; i<=100; i++)
            {
                Console.WriteLine(FizzBuzz.Calculate(i));
            }
        }
    }
}
