using System;
using System.Linq;

namespace PalindromeLibrary
{
    public class PalindromeClass: IPalindrome
    {
        public bool IsPalindrome(string str)
        {
            //Change string to Lowercase so comparison is case insensitive
            str = str.ToLower();
            //Remove non alphanumeric characters using Linq
            str = String.Concat(str.Where(char.IsLetterOrDigit));
            //Convert input to char array
            char[] arr = str.ToCharArray();
            //Reverse char array
            Array.Reverse(arr);
            //Check if input equals reversed array
            if (str == (new String(arr)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
