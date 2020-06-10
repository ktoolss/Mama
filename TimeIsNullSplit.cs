using System;
namespace csharptutorial.Strings
{
    public class TimeIsNullSplit
    {
        public TimeIsNullSplit()
        {
            Console.WriteLine("Enter a time: ");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid time");
                return;
            }

            var components = input.Split(':');

            if (components.Length != 2)
            {
                Console.WriteLine("Invalid time");
                return;
            }

            try
            {
                var hour = Convert.ToInt32(components[0]);
                var minute = Convert.ToInt32(components[1]);


                if (hour >= 0 && hour <= 23 && minute >= 0 && minute <= 59)
                    Console.WriteLine("ok");
                else
                    Console.WriteLine("Invalid time");
            }
            catch(Exception)
            {
                Console.WriteLine("InvalidTime");
            }
        }
    }
}
