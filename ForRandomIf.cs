using System;
namespace csharptutorial.ExerciseTwoFour
{
    public class ForRandomIf
    {
        public ForRandomIf()
        {
            var number = new Random().Next(1, 10);

            for (var i = 0; i < 4; i++)
            {
                Console.WriteLine("Guess the random number in four tries");
                var guess = Convert.ToInt32(Console.ReadLine());

                if (guess == number)
                {
                    Console.WriteLine("The random number is " + number);
                    Console.WriteLine("You won!");
                    return;
                }
            }
            Console.WriteLine("Random number is " + number);
            Console.WriteLine("You lose...");
        }
    }
}
