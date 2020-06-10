using System;
namespace csharptutorial.ExerciseTwoOne
{
    public class ForIfCount
    {
        public ForIfCount()
        {
            var count = 0;

            for(var i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                    count++;
            }
            Console.WriteLine("There is " + count + " numbers divisible by 3 between 1 and 100");
        }
    }
}
