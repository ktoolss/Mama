using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace csharptutorial
{

    class ForeachIfSplit
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a few numbers in a string seperated by a comma.");

            var input = Console.ReadLine();

            var numbers = input.Split(',');

            var max = Convert.ToInt32(numbers[0]);

            foreach (var str in numbers)
            {
                var number = Convert.ToInt32(str);
                if (number > max)
                    max = number;
            }

            Console.WriteLine("max is " + max);
        }

    }

}
