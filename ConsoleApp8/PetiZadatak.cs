using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class DrugiZadatak
    {
        public List<string> ExtractPalindromes(List<string> words)
        {
            List<string> palindromes = new List<string>();
            if (words == null) return palindromes;
            foreach (string word in words)
            {
                if(IsPalindrome(word))
                {
                    palindromes.Add(word);
                }
            }
            return palindromes;
        }
        public bool IsPalindrome(string word)
        {
            string trimmedWord = word.Replace(" ", "").ToLower();
            string reversedWord = new string(trimmedWord.Reverse().ToArray());

            if (trimmedWord.Equals(reversedWord))
            {
                return true;
            }
            return false;

        }
    }
}
