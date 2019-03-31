using System;

/**
 * Class: CSE 1322L
 * Section: 07
 * Term: Spring
 * Instructor: Kevin Markley
 * Name: Nicolas Capparelli
 * Lab#: 6B
 */

namespace LabSixB {
    internal class Program {
        
        public static void Main(string[] args) {

            var shouldStop = false;

            do {
                   
                Console.Write("Enter time in 24-hour notation: ");
                var time = Console.ReadLine();

                try {
                    Console.WriteLine("That is the same as: " + ConvertTime(time));
                    Console.Write("Again?(y/n): ");
                    if (Console.ReadKey().Key == ConsoleKey.N) {
                        shouldStop = true;
                    }
                    Console.WriteLine();

                } catch (TimeFormatException e) {
                    Console.WriteLine("There is no such time as: " + time);
                    Console.WriteLine("Try Again");
                }
                
            } while (!shouldStop);

            Console.WriteLine("Thank you - End of program.");
        }

        private static string ConvertTime(string twentyFourHourTime) {
            int hour;
            int minutes;
            
            // Exception handling
            try {
                 hour = int.Parse(twentyFourHourTime.Split(':')[0]);
                 minutes = int.Parse(twentyFourHourTime.Split(':')[1]);
                
            } catch (FormatException e) {
                Console.WriteLine(e);
                throw new TimeFormatException("Invalid Format");
            }
            
            if (hour < 0 || hour > 24 || minutes < 0 || minutes > 60) {
                throw new TimeFormatException("Your time is out of the range.");
            } else if (!twentyFourHourTime.Contains(":")) {
                throw new TimeFormatException("Invalid Format");
            }
            
            // Time conversion
            if (hour > 12) {
                return (hour - 12).ToString() + ":" + twentyFourHourTime.Split(':')[1] + " PM";
            } else if (hour == 12) {
                return twentyFourHourTime + " PM"; 
            }

            return twentyFourHourTime + " AM";
        }
    }
}