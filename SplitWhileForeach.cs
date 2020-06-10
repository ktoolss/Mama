using System;
using System.Collections.Generic;
namespace csharptutorial.ExerciseThreeFive
{
    public class SplitWhileForeach
    {
        public SplitWhileForeach()
        {
            string[] elements;

            while(true)
            {
                Console.WriteLine("Enter a list of five comma separated numbers.");
                var input = Console.ReadLine();

                if(!String.IsNullOrWhiteSpace(input))
                {
                    elements = input.Split(',');
                    if (elements.Length >= 5)
                        break;
                }

                Console.WriteLine("Invalid List");
            }

            var numbers = new List<int>();

            foreach (var number in elements)
                numbers.Add(Convert.ToInt32(number));

            var smallest = new List<int>();
            while(smallest.Count < 3)
            {
                var min = numbers[0];
                foreach(var number in numbers)
                {
                    if (number < min)
                        min = number;
                }
                smallest.Add(min);

                numbers.Remove(min);
            }
            Console.WriteLine("3 smallest numbers are: ");
            foreach (var number in smallest)
                Console.WriteLine(number);
        }
    }
}
