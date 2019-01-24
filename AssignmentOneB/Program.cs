using System;
using System.Collections;

namespace AssignmentOneB {
    internal class Program {
        public static void Main(string[] args) {
            var allTestsObjects = new ArrayList();

            Console.WriteLine("Please input data in the following format:\n" +
                              "FirstName LastName Score1 Score2 Score3 Score4 Score5");
            Console.WriteLine("Enter DONE when finished");

            string input;
            do {
                
                input = Console.ReadLine();
                
                // If user types DONE, stop taking input
                if (input.Equals("DONE")) {break;}

                var testObject = createStudent(input);
                
                // If the data inputted is valid, in the sense that the program is able to create a Tests Object with it
                if (!testObject.FirstName.Equals("Invalid")) {
                    allTestsObjects.Add(testObject);
                } else {
                    Console.WriteLine("Invalid data inputted");
                }
               
            } while (!input.Equals("DONE"));
            
            // Printing the data and calculating average
            Console.WriteLine("First Name\tLast Name\tTest1\tTest2\tTest3\tTest4\tTest5\tAverage\tGrade");
            double classAverage = 0;
            foreach (Tests student in allTestsObjects) {
                classAverage += student.AverageTestScore;
                Console.WriteLine(student.getAllData());    
            }
            Console.WriteLine("Class Average: " + classAverage / allTestsObjects.Count);
        }

        private static Tests createStudent(string studentString) {

            var splitString = studentString.Split(' ');
                            
            // temp arrayList to hold the grades
            var tempAl = new ArrayList();

            for (var index = 2; index < splitString.Length; index++) {
                
                // Attempt to parse string as double, if unable, data is invalid
                try {
                    tempAl.Add(double.Parse(splitString[index]));
                }
                catch {
                    return new Tests("Invalid", "Data", new double[]{0,0,0,0,0});
                }
            }
            
            // Attempt to create a Tests object with data, if unable, data is invalid
            try {
                var finalTest = new Tests(splitString[0], splitString[1], (double[])tempAl.ToArray(typeof(double)));
                return finalTest;
            }
            catch {
                return new Tests("Invalid", "Data", new double[]{0,0,0,0,0});
            }
        }
        
        // Method to test with constant data and no user input
        public static void testData() {
            
            var tests = new ArrayList();

            const string testData = "Jack Johnson 85 83 77 91 76\n" +
                                    "Lisa Aniston 80 90 95 93 48\n" +
                                    "Andy Cooper 78 81 11 90 73\n" +
                                    "Ravi Gupta 92 83 30 69 87\n" +
                                    "Bonny Blair 23 45 96 38 59\n" +
                                    "Danny Clark 60 85 45 39 67\n" +
                                    "Samantha Kennedy 77 31 52 74 83\n" +
                                    "Robin Bronson 93 94 89 77 97\n" +
                                    "Sun Xie 79 85 28 93 82\n" +
                                    "Kiran Patel 85 72 49 75 63\n";

            foreach (var studentString in testData.Split('\n')) {
                
                // Array of all substrings in studentString
                var line = studentString.Replace('\n', ' ').Split(' ');

                // temp arrayList to hold the grades
                var tempAl = new ArrayList();
                
                for (var i = 2; i < line.Length; i++) {
                    try {
                        tempAl.Add(double.Parse(line[i].Trim()));
                    }
                    catch (Exception e) {
                        Console.WriteLine(e);
                    }
                }

                try {
                    tests.Add(new Tests(line[0], line[1], (double[])tempAl.ToArray(typeof(double))));
                }
                catch (Exception e) {}
            }
            
            Console.WriteLine("First Name\tLast Name\tTest1\tTest2\tTest3\tTest4\tTest5\tAverage\tGrade");
            
            foreach (Tests student in tests) {
                Console.WriteLine(student.getAllData());    
            }
            
            
        }
    }
}