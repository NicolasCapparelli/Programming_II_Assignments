using System;

/**
 * Class: CSE 1322L
 * Section: 07
 * Term: Spring
 * Instructor: Kevin Markley
 * Name: Nicolas Capparelli
 * Assignment#: 5B
 */

namespace AssignmentFiveB {
    internal class Program {
        public static void Main(string[] args) {
            var birds = new BirdSurvey();

            for (;;) {
                Console.WriteLine("Please enter bird species:");
                var dataEntered = Console.ReadLine();

                if (!dataEntered.Equals("done")) {
                    birds.add(dataEntered);
                } else {
                    break;
                }
            }
            
            // Report of all birds
            Console.WriteLine("Here is a report for all of the birds:");
            Console.WriteLine("------------------------------");
            birds.getReport();
            
            // Note: Usage of getCount is within the BirdList class
        }
    }
}