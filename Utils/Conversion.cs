using System;
using System.Collections.Generic;

namespace PhonePadTest.Utils
{
    public static class Conversion
    {
        public static char Convert(string text)
        {
            string[] keypad = { " ", "&'(", "ABC", "DEF", "GHI", "JKL", "MNO", "PQRS", "TUV", "WXYZ" };

            int key = int.Parse(text[0].ToString());
            if (key < 0 || key > 9)
                throw new ArgumentException("Invalid key");
            //Console.WriteLine(text.Length); for debugging
            //Console.WriteLine(keypad[key].Length);  for debugging

            if ((text.Length % keypad[key].Length) == 0)
            {
                return keypad[key][keypad[key].Length - 1];
            }
            else
            {
                return keypad[key][text.Length % keypad[key].Length - 1];
            }
        }

        public static string OldPhonePad(string input)
        {
            List<string> arr = new List<string>();
            int i = 0;

            while (i < input.Length)
            {
                if (input[i] == '#')
                    break;

                if (input[i] == '*')
                {
                    if (arr.Count > 0)
                        arr.RemoveAt(arr.Count - 1);
                    i++;
                    continue;
                }

                if (input[i] == ' ')
                {
                    i++;
                    continue;
                }

                if (i == 0 || input[i] != input[i - 1])
                {
                    arr.Add(input[i].ToString());
                }
                else
                {
                    arr[arr.Count - 1] += input[i];
                }

                i++;
            }

            List<char> converted = new List<char>();

            foreach (string t in arr)
            {
                converted.Add(Conversion.Convert(t));
            }

            return string.Join("", converted);
        }
    }
}