using System;
using System.Numerics;
using System.Text;

namespace ConfirmationCodes
{
    public static class Conversions
    {
        public static BigInteger RepresentationToValue(string value, string characterSet)
        {
            var @base = characterSet.Length;
            BigInteger result = 0;

            foreach(var c in value)
            {
                result = @base * result + characterSet.IndexOf(c);
            }

            return result;
        } 

        public static string ValueToRepresentation(BigInteger value, string characterSet)
        {
            var sb = new StringBuilder();
            var @base = characterSet.Length;

            while (value > 0)
            {
                sb.Append(characterSet.Substring((int)(value % @base), 1));
                value = value / @base;
            }

            var result = sb.ToString().ToCharArray();
            Array.Reverse(result);
            return new string(result);
        }

        public static string BaseToBase(string value, string fromBase, string toBase)
        {
            return ValueToRepresentation(RepresentationToValue(value, fromBase), toBase);
        }
    }
}