namespace ConfirmationCodes
{
    public static class Constants
    {
        public const string Base2Binary = "01";

        public const string Base16Hexadecimal = "0123456789ABCDEF";

        public const string Base32Rfc4648 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ234567";

        /// <summary>Bits and fragments of words that should be avoided within
        /// the resulting confirmation code. This is just a list of the obvious
        /// ones.</summary>
        public static readonly string[] BadEnglishWords = new string[] 
        {
            "ANU",
            "ARS",
            "AS",
            "BAS",
            "BIT",
            "CHRI",
            "CRA",
            "CUN",
            "DAM",
            "FUC",
            "GGA",
            "GOD",
            "HIT",
            "JES",
            "KIK",
            "PIS",
            "SEX",
            "TWA",
            "XXX",
            "WAN",
        };
    }
}