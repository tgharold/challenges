using System;

namespace FizzyBuzzy
{
    public static class FizzBuzz
    {
        public static string Calculate(int i)
        {
            var result = (i % 3 == 0) ? "Fizz" : "";
            result += (i % 5 == 0) ? "Buzz" : "";
            return string.IsNullOrEmpty(result) ? i.ToString() : result;
        }
    }
}