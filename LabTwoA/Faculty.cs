using System;

namespace LabTwoA {
    public class Faculty : Employee {
        
        private string officeHours;
        private string rank;
        
        public Faculty(string name, string address, string phoneNumber, string email, string office, double salary, MyDate dateHired, string officeHours, string rank) :
            base(name, address, phoneNumber, email, office, salary, dateHired) {
            this.officeHours = officeHours;
            this.rank = rank;
        }
        
        public override void DisplayData() {
            base.DisplayData();
            Console.WriteLine("\tOffice Hours: " + officeHours);
            Console.WriteLine("\tRank: " + rank);
            Console.WriteLine("\tObject Type: FacultyMember");
            Console.WriteLine();
        }
    }
}