using System;
using System.Collections.Generic;
namespace csharptutorial.ExerciseThreeThree
{
    public class ListwhileIfForeach
    {
        public ListwhileIfForeach()
        {
            var numbers = new List<int>();

            while (numbers.Count < 5)
            {
                Console.WriteLine("Enter five unique numbers.");

                var number = Convert.ToInt32(Console.ReadLine());

                if (numbers.Contains(number))
                {
                    Console.WriteLine("You've previously entered " + number);
                    continue;
                }

                numbers.Add(number);
            }
            numbers.Sort();

            foreach (var number in numbers)
                Console.WriteLine(number);
        }
    }
}
