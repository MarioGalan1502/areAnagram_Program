using System;

namespace areAnagrams
{
    public class checkAnagrams
    {
        static void Main(string[] args)
        {
            Console.WriteLine("primera palabra:");
            string word1=Console.ReadLine();
            Console.WriteLine("segunda palabra:");
            string word2 = Console.ReadLine();

            checkAnagrams check = new checkAnagrams();

            if(check.isAnagram(word1,word2))
            {
                Console.WriteLine($"\nSi, {word1} es una anagrama de {word2} :) \n");
            }
            else
            {
                Console.WriteLine($"\nNO, {word1} no es una anagrama de {word2} :( \n");
            }
        }

        public bool isAnagram(string word1,string word2)
        {
            if(word1 == null || word2 == null)
            {
                throw new ArgumentNullException();
            }

            if(!is_Word(word1) || !is_Word(word2))
            {
                throw new ArgumentException("no se introdujo una palabra");
            }

            char[] char1 = word1.ToLower().ToCharArray();
            char[] char2 = word2.ToLower().ToCharArray();

            Array.Sort(char1);
            Array.Sort(char2);

            string new_word1 = new string(char1);
            string new_word2 = new string(char2);

            if(new_word1 == new_word2)
            {
                return true;
            }
            else
            {
                return false;
            }

            
        }

        public static bool is_Word(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if(!char.IsLetter(word[i]))
                {
                    return false;
                }
            }

            return true;

        }
    }
}
