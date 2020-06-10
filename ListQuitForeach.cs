using System;
using System.Collections.Generic;
namespace csharptutorial.ExerciseThreeFour
{
    public class ListQuitForeach
    {
        public ListQuitForeach()
        {
            var numbers = new List<int>();

            while (true)
            {
                Console.WriteLine("Enter a number (or QUIT to exit).");
                var input = Console.ReadLine();

                if (input.ToLower() == "quit")
                    break;

                numbers.Add(Convert.ToInt32(input));
            }
            
            var uniques = new List<int>();

            foreach(var number in numbers)
            {
                if (!uniques.Contains(number))
                    uniques.Add(number);
            }

            Console.WriteLine("Unique numbers: ");
            foreach (var number in uniques)
                Console.WriteLine(number);
        }
    }
}
