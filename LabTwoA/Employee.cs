using System;

namespace LabTwoA {
    public class Employee : Person {

        private string office;
        private double salary;
        private MyDate dateHired;
        
        // An employee has an office, salary, and date hired
        public Employee(string name, string address, string phoneNumber, string email, string office,
            double salary, MyDate dateHired) : base(name, address, phoneNumber, email) {

            this.office = office;
            this.salary = salary;
            this.dateHired = dateHired;
        }
        
        public override void DisplayData() {
            base.DisplayData();
            Console.WriteLine("\tOffice: " + office);
            Console.WriteLine("\tSalary: " + $"{salary:C}");
            Console.WriteLine("\tDate Hired: " + dateHired.getDate());
            Console.WriteLine("\tObject Type: Employee");
            Console.WriteLine();
        }
    }
}