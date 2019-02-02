using System;

namespace LabTwoA {
    public class Employee : Person {

        private string _office;
        private double _salary;

        private MyDate _dateHired;


        public Employee(PersonFactory pFactory) : base(pFactory) {
            _office = pFactory.OfficeValue ?? "";
            _salary = pFactory.SalaryValue ?? 0;
            _dateHired = pFactory.DateHiredValue ?? new MyDate(0,0,0);
        }
        
        // An employee has an office, salary, and date hired
        public override void DisplayData() {
            base.DisplayData();
            Console.WriteLine("\tOffice: " + _office);
            Console.WriteLine("\tSalary: " + $"{_salary:C}");
            Console.WriteLine("\tDate Hired: " + _dateHired.getDate());
            Console.WriteLine("\tObject Type: Employee");
            Console.WriteLine();
        }
    }
}