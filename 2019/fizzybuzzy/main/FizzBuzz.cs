namespace FizzyBuzzy
{
    public static class FizzBuzz
    {
        public static string Calculate(int i)
        {
            if (i % 3 == 0 && i % 5 == 0) return "FizzBuzz";
            if (i % 5 == 0) return "Buzz";
            if (i % 3 == 0) return "Fizz";
            return i.ToString();
        }
    }
}