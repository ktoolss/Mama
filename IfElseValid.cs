using System;
namespace csharptutorial.ExerciseOneOne
{
    public class IfElseValid
    {
        public IfElseValid()
        {
            Console.WriteLine("Enter a number between 1 and 10.");
            var input = Console.ReadLine();
            var number = Convert.ToInt32(input);

            if (number >= 1 && number <= 10)
                Console.WriteLine("Valid");
            else
                Console.WriteLine("Invalid");
        }
    }
}
