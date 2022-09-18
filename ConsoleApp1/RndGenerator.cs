using System;
using System.Collections.Generic;

namespace Program
{
    static class RndGenerator
    {
        private static Random rnd = new Random(DateTime.Now.Millisecond);
        public static string GenerateName(int len)
        {
            string[] consonants = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "l", "n", "p", "q", "r", "s", "sh", "zh", "t", "v", "w", "x" };
            string[] vowels = { "a", "e", "i", "o", "u", "ae", "y" };
            string Name = "";
            Name += consonants[rnd.Next(consonants.Length)].ToUpper();
            Name += vowels[rnd.Next(vowels.Length)];
            int b = 2; //b tells how many times a new letter has been added. It's 2 right now because the first two letters are already in the name.while (b < len)
            while (b < len)
            {
                if (b % 2 == 0)
                {
                    Name += consonants[rnd.Next(consonants.Length)];
                }
                else
                {
                    Name += vowels[rnd.Next(vowels.Length)];
                }
                b++;

            }

            return Name;
        }
        public static DateTime GenerateBornDate()
        {
            return DateTime.Now.AddYears(-(rnd.Next(16, 30))).AddDays(rnd.Next(1, 365));
        }
        public static DateTime GenerateExamDate()
        {
            return DateTime.Now.AddDays(rnd.Next(1, 365));
        }
    }
}