using System;
namespace csharptutorial.Strings
{
    public class ToUpperToLower
    {
        public ToUpperToLower()
        {
            Console.WriteLine("Enter a few words: ");
            var input = Console.ReadLine();

            if(String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Error");
                return;
            }

            var variableName = " ";

            foreach (var word in input.Split(' '))
            {
                var wordWithPascalCase = char.ToUpper(word[0]) + char.ToLower(word[1]);

                variableName += wordWithPascalCase;
            }
            Console.WriteLine(variableName);
        }
    }
}
