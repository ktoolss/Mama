using System;
using System.Collections.Generic;

namespace csharptutorial.Strings
{
    public class ToLowerCharList
    {
        public ToLowerCharList()
        {
            Console.WriteLine("Enter a word: ");
            var input = Console.ReadLine().ToLower();

            var vowels = new List<char>(new char[] { 'a', 'e', 'o', 'u', 'i' });
            var vowelsCount = 0;

            foreach(var character in input)
            {
                if (vowels.Contains(character))
                    vowelsCount++;
            }

            Console.WriteLine(vowelsCount);
        }
    }
}
