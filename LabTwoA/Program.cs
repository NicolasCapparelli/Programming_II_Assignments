using System;

namespace LabTwoA {

    internal class Program {
        public static void Main(string[] args) {
            var pFactory = new PersonFactory();

            var person = pFactory.Name("John Doe")
                .Address("3630 Front Street")
                .PhoneNumber("810-448-4050")
                .Email("jd@gmail.com")
                .BuildPerson();
            person.DisplayData();
            Console.WriteLine();
            
            var student = pFactory.Name("Lane Johnson")
                .Address("3959 Michael Street")
                .PhoneNumber("713-794-1984")
                .Email("lj@gmail.com")
                .ClassStatus(Student.Status.Freshman)
                .BuildStudent();
            student.DisplayData();
            Console.WriteLine();
            
            var employee = pFactory.Name("Nick Foles")
                .Address("344 Franklin Street")
                .PhoneNumber("334-707-2499")
                .Email("bdn@gmail.com")
                .Office("NF99")
                .Salary(4000000)
                .DateHired(new MyDate(09,19,1999))
                .BuildEmployee();
            employee.DisplayData();
            Console.WriteLine();
            
            var faculty = pFactory.Name("Jimmy Ledger")
                .Address("3724 Oakridge Lane")
                .PhoneNumber("478-275-5702")
                .Email("jl@hotmail.com")
                .Office("JL09")
                .Salary(60000)
                .DateHired(new MyDate(09,9,2003))
                .OfficeHours("4pm-6pm")
                .Rank("Professor")
                .BuildFaculty();
            faculty.DisplayData();
            Console.WriteLine();
            
            var staff = pFactory.Name("Hannah Smith")
                .Address("3724 Riverview Lane")
                .PhoneNumber("404-305-5978")
                .Email("hs@hotmail.com")
                .Office("HS09")
                .Salary(60000)
                .DateHired(new MyDate(08,20,2008))
                .OfficeHours("4pm-6pm")
                .Rank("Professor")
                .Title("Dean")
                .BuildStaff();
            staff.DisplayData();
            Console.WriteLine();
        }
    }
}