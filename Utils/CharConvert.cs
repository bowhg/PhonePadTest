using System;

namespace PhonePadTest.Utils
{
    public static class CharConversion
    {
        public static char Convert(string text)
        {
            string[] keypad = { " ", "&'(", "ABC", "DEF", "GHI", "JKL", "MNO", "PQRS", "TUV", "WXYZ" };

            int key = int.Parse(text[0].ToString());
            return keypad[key][text.Length - 1];
        }
    }
}