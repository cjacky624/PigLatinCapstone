using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigLatinFinal
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Please enter any word");
            string word = Console.ReadLine().ToLower();
            int vowelIndex = word.IndexOfAny(new char[] { 'a', 'e', 'i', 'o', 'u' });
            Console.WriteLine(ToPigLatin(word, vowelIndex));
            Console.ReadKey();

            Console.WriteLine("Would you like to translate another word? Yes or No");

        }

        private static string ToPigLatin(string word, int vowelIndex)
        {
            string vowels = "aeiou";

            int i = 0;
            if (word[0] == vowels[0] || word[0] == vowels[1] || word[0] == vowels[2] || word[0] == vowels[3] || word[0] == vowels[4])
            {
                word = word + "way";
            }
            else if (word[0] != vowels[0] && word[0] != vowels[1] && word[0] != vowels[2] && word[0] != vowels[3] && word[0] != vowels[4])
            {
                for (; i < vowelIndex; i++)
                {
                    word = word + word[i];


                }
                word = word.Substring(i);
                word = word + "ay";
            }
            return word;
        }
    }
}
