using System;
using System.Linq;

namespace HoloalphabeticSentence
{
    public class HoloalphabeticSentence
    {
        public static bool IsHoloalphabeticSentence(string input, string alphabets = "abcdefghijklmnopqrstuvwxyz")
        {
            if (input == string.Empty)
                return false;
            char[] inputArray = input.ToLower().ToCharArray();

            for(int i = 0; i < alphabets.Length; i++)
            {
                if (!inputArray.Contains(alphabets[i]))
                    return false;

            }

            return true;
        }
    }
}
