using System;
namespace csharptutorial.ExerciseOneTwo
{
    public class IfElseMax
    {
        public IfElseMax()
        {
            Console.WriteLine("Enter a number.");
            var number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter another number.");
            var number2 = Convert.ToInt32(Console.ReadLine());

            var max = (number1 > number2) ? number1 : number2;
            Console.WriteLine("Max value is " + max);
        }
    }
}
