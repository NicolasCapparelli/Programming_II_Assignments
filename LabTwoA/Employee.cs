using System;

namespace LabTwoA {
    public class Employee : Person {

        private string office;
        private double salary;

        public MyDate dateHired { get; set; }


        public Employee(PersonFactory pFactory) : base(pFactory) {
            office = pFactory.OfficeValue ?? "";
            salary = pFactory.SalaryValue ?? 0;
            dateHired = pFactory.DateHiredValue ?? new MyDate(0,0,0);
        }
        
        // An employee has an office, salary, and date hired
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