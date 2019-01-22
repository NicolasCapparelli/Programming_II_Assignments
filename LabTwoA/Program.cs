using System;

namespace LabTwoA {
    
    // TODO: Create a factory
    internal class Program {
        public static void Main(string[] args) {
            
            var person = new Person("John Doe", "3630 Front Street", "810-448-4050",
                "jd@gmail.com");
            person.DisplayData();
            Console.WriteLine();
            
            var student = new Student("Lane Johnson", "3959 Michael Street", "713-794-1984",
                "lj@gmail.com", Student.Status.Freshman);
            student.DisplayData();
            
            var employee = new Employee("Nick Foles", "344 Franklin Street", "334-707-2499",
                "bdn@gmail.com", "J999", 4000000, new MyDate(9, 19, 1999));
            employee.DisplayData();
            
            //var facultyMember = new FacultyMember("Jimmy Ledger", "3724 Oakridge Lane",
                //"478-275-5702", "jl@hotmail.com", "4pm-6pm", "??");
            // facultyMember.DisplayData();
            
        }
    }
}