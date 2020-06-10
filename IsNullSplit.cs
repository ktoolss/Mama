using System;
using System.Collections.Generic;

namespace csharptutorial.Strings
{
    public class IsNullSplit
    {
        public IsNullSplit()
        {
            Console.WriteLine("Enter a few numbers (eg 1-2-3-4): ");

            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
                return;

            var numbers = new List<int>();

            foreach (var number in input.Split('-'))
                numbers.Add(Convert.ToInt32(number));

            var uniques = new List<int>();
            var includesDuplicates = false;

            foreach (var number in numbers)
            {
                if (!uniques.Contains(number))
                    uniques.Add(number);
                else
                {
                    includesDuplicates = true;
                    break;
                }
            }

            if(includesDuplicates)
                Console.WriteLine("Duplicate");
        }
    }
}
