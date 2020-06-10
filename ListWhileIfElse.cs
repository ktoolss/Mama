using System;
using System.Collections.Generic;
namespace csharptutorial.ExcerciseThreeOne
{
    public class ListWhileIfElse
    {
        public ListWhileIfElse()
        {
            var names = new List<String>();

            while (true)
            {
                Console.WriteLine("Enter a name (or hit enter to quit): ");
                var input = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(input))
                    break;

                names.Add(input);

            }
            if (names.Count > 2)
                Console.WriteLine($"{names[0]}, {names[1]}, and {names.Count - 2} others like your post.");
            else if (names.Count == 2)
                Console.WriteLine($"{names[0]}, and {names[1]} like your post.");
            else if (names.Count == 1)
                Console.WriteLine($"{names[0]} like your post");
            else
                Console.WriteLine();
        }
    }
}
