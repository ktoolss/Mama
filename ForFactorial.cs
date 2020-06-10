using System;
namespace csharptutorial.ExcerciseTwoThree
{
    public class ForFactorial
    {
        public ForFactorial()
        {
            Console.WriteLine("Enter a number");
            var number = Convert.ToInt32(Console.ReadLine());

            var factorial = 1;
            for (var i = 1; i <= number; i++)
                factorial *= i;

            Console.WriteLine($"{number}!={factorial}");
        }
    }
}
