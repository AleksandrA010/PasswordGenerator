using System;
using System.Collections.Generic;
using System.Linq;

namespace PasswordGenerator
{
    internal class Generator
    {
        readonly List<char> nonLetterChars = new List<char>() { '{', '}', '[', ']', '(', ')', '/', '\\', '`', '"', '~', ',', ';', ':', '.', '<', '>' };
        readonly List<char> duplicateChars = new List<char>() { 'i', 'l', '1', 'L', 'o', '0', 'O' };
        readonly List<char> numberChars = new List<char>() { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        readonly List<char> letterChars = new List<char>() { 'q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o',
            'p', 'a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'z', 'x', 'c', 'v', 'b', 'n', 'm' };

        public string GeneratePassword(int length, bool isNonLetterChars, bool isDuplicateChars)
        {
            List<char> currentList = numberChars;
            for (int i = 0; i < letterChars.Count; i++)
            {
                currentList.Add(letterChars[i]);
            }

            string result = string.Empty;
            Random rand = new Random();

            if (isNonLetterChars)
            {
                for (int i = 0; i < nonLetterChars.Count; i++)
                {
                    currentList.Add(nonLetterChars[i]);
                }
            }

            else if (isDuplicateChars)
            {
                for (int i = 0; i < length; i++)
                {
                    result += currentList[rand.Next(0, currentList.Count - 1)];
                }
            }
            else
            {
                for (int i = 0; i < length; i++)
                {
                    char newChar = currentList[rand.Next(0, currentList.Count - 1)];
                    if (letterChars.Contains(newChar))
                    {
                        result += newChar;
                    }
                    else
                    {
                        i--;
                        continue;
                    }
                }
            }

            return result;
        }
    }
}
