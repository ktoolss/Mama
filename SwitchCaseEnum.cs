using System;
namespace csharptutorial.SwitchCase
{
    public class SwitchCaseEnum
    {
        public SwitchCaseEnum()
        {
            var season = Season.Autumn;

            switch (season)
            {
                case Season.Autumn:
                    Console.WriteLine("It's Autumn");
                    break;

                case Season.Summer:
                    Console.WriteLine("It's Summer");
                    break;

                default:
                    Console.WriteLine("I don't understand the season.");
                    break;
            }
        }

        public enum Season
        {
            Spring,
            Summer,
            Autumn,
            Winter
        }
    }
}
