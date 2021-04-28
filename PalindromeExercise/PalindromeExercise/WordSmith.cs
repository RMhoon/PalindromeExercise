using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string word)
        {
           return word.ToLower() == string.Join("", word.ToLower().Reverse());
        }
    }
}
