using System;
/**
 * Class: CSE 1322L
 * Section: 07
 * Term: Spring
 * Instructor: Kevin Markley
 * Name: Nicolas Capparelli
 * Assignment#: 4
 */

namespace AssignmentFourB {
    internal class Program {
        
        public static void Main(string[] args) {
            var con = new Converter();

            Console.WriteLine("Enter Decimal (Base 10) Value: ");
            var dec = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter Desired Base (2-36 only): ");
            var tarB = int.Parse(Console.ReadLine());

            if (tarB < 2 || tarB > 36) {
                Console.WriteLine("Bases less than 2 or greater than 36 are invalid");
                return;
            }

            Console.WriteLine("------------------------------------------------");
            Console.WriteLine(dec + " in base " + tarB + " is: " + con.Convert(dec, tarB));
        }

        // For test use only
        private void TestData() {
            var con = new Converter();
            Console.WriteLine(con.Convert(9098, 20));
            Console.WriteLine(con.Convert(692, 2));
            Console.WriteLine(con.Convert(753, 16));
        }
        


    }
}