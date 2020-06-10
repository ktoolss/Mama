using System;
namespace csharptutorial.TimeSpanDateTime
{
    public class TimeSpanExample
    {
        public TimeSpanExample()
        {
            var timeSpan = new TimeSpan(1, 2, 3);

            var timeSpan1 = new TimeSpan(1, 0, 0);

            var timeSpan2 = TimeSpan.FromHours(1);

            var start = DateTime.Now;

            var end = DateTime.Now.AddMinutes(2);

            var duration = end - start;

            Console.WriteLine("Duration: " + duration);

            Console.WriteLine("Minutes: " + timeSpan.Minutes); // Displays 2 minutes from var timeSpan

            Console.WriteLine("Total Minutes: " + timeSpan.TotalMinutes); // display total 60 + 2 minutes from timeSpan
        }
    }
}
