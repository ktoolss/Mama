using System;
namespace csharptutorial.ExerciseOneThree
{
    public class IfElseEnumOrientation
    {
        public IfElseEnumOrientation()
        {
            Console.WriteLine("Enter the height of an image: ");
            var height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the width of the image: ");
            var width = Convert.ToInt32(Console.ReadLine());

            var orientation = width > height ? ImageOrientation.Landscape : ImageOrientation.Portrait;
            Console.WriteLine("This image is an " + orientation);
        }

        public enum ImageOrientation
        {
            Landscape,
            Portrait
        }
    }
}
