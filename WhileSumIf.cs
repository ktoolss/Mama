using System;
namespace csharptutorial.ExerciseTwoTwo
{
    public class WhileSumIf
    {
        public WhileSumIf()
        {
            var sum = 0;
            while (true)
            {
                Console.WriteLine("Enter a number or enter ok: ");
                var input = Console.ReadLine();

                if (input.ToLower() == "ok")
                    break;
                sum += Convert.ToInt32(input);
            }
            Console.WriteLine("Sum of all numbers is " + sum);
        }
    }
}
