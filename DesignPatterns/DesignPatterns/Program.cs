using DesignPatterns.Singleton;
using System;
using static DesignPatterns.Enums.CommonEnums;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write the name of the design pattern");

            string designPatternName =Console.ReadLine();

            switch (designPatternName.ToLower().Trim())
            {
                case "singleton":
                    ExcuteSingleTonDesignPattern();
                    break;
                default:
                    break;
            }
        }

        private static void ExcuteSingleTonDesignPattern()
        {
            var database = SingletonDatabase.Instance;
            var population= database.GetPopulation("bhubaneswar");
            ColoredConsoleWriteLine(ConsoleColors.White, ConsoleColors.Blue, $"Popuation:{population}");
        }

        private static void ColoredConsoleWriteLine(ConsoleColors foregroudcolor,ConsoleColors backgroundcolor,string message)
        {
            Console.ForegroundColor = (ConsoleColor)foregroudcolor;
            Console.BackgroundColor = (ConsoleColor)backgroundcolor;
            Console.WriteLine( message);
            Console.ResetColor();
        }
    }

}
