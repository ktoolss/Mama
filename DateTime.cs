using System;
namespace csharptutorial.TimeSpanDateTime
{
    public class DateTimeExample
    {
        public DateTimeExample()
        {
            var dateTime = new DateTime(2015, 1, 1);
            var now = DateTime.Now;
            var today = DateTime.Today;

            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            Console.WriteLine(now.ToLongDateString());

            Console.WriteLine(now.ToShortDateString());

            Console.WriteLine(now.ToLongTimeString());

            Console.WriteLine(now.ToShortTimeString());

            Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));
        }
    }
}
