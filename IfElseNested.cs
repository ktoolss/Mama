using System;
namespace csharptutorial.ExerciseOneFour
{
    public class IfElseNested
    {
        public IfElseNested()
        {
            Console.WriteLine("Enter the speed limit and then the speed of a car.");
            var speedLimit = Convert.ToInt32(Console.ReadLine());
            var carSpeed = Convert.ToInt32(Console.ReadLine());

            if(carSpeed <= speedLimit)
                Console.WriteLine("ok");

            else
            {
                const int kmPerDemeritPoint = 5;
                var demeritPoints = (carSpeed - speedLimit) / kmPerDemeritPoint;

                if (demeritPoints > 12)
                    Console.WriteLine("License Suspended!");

                else
                    Console.WriteLine("Demerit Points: " + demeritPoints);
            }
        }
    }
}
