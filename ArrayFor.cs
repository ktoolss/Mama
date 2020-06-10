using System;

namespace csharptutorial.ExerciseThreeTwo
{
    public class ArrayFor
    {
        public ArrayFor()
        {
            Console.WriteLine("What's your name?");
            var name = Console.ReadLine();
            
            var array = new char[name.Length];

            Array.Reverse(array);

            for (var i = name.Length; i > 0; i--)
                array[name.Length - 1] = name[i - 1];

            var reversed = new string(array);
            Console.WriteLine("Reversed name " + reversed);
        }
    }
}
